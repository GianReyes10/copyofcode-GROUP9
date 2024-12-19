using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using PdfSharp.Pdf;
using PdfSharp.Drawing;


namespace LibraryManagementSystem
{
    public partial class Borrow : Form
    {
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb");
        public Borrow()
        {
            InitializeComponent();
            tbSID.Leave += (s, e) => AutofillStudentDetails();
            tbBID.Leave += (s, e) => AutofillBookDetails();
            tbBN.Leave += (s, e) => AutofillBookDetails();
        }
        private void LoadBorrowedBooks()
        {
            try
            {
                // Open Database Connection
                conn.Open();

                // Fetch Borrowed Books Data
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM BooksBorrowed", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind Data to DataGridView
                dgvBorrowedBooks.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AutofillStudentDetails()
        {
            if (string.IsNullOrWhiteSpace(tbSID.Text)) return;

            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [FullName], [Grade], [Section], [Contact] FROM StudentList WHERE [Student ID] = @StudentID", conn);
                cmd.Parameters.AddWithValue("@StudentID", tbSID.Text);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbFN.Text = reader["FullName"].ToString();
                    tbG.Text = reader["Grade"].ToString();
                    tbS.Text = reader["Section"].ToString();
                    tbC.Text = reader["Contact"].ToString();
                }
                else
                {
                    MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void AutofillBookDetails()
        {
            string query = "";
            string parameter = "";

            if (!string.IsNullOrWhiteSpace(tbBID.Text))
            {
                query = "SELECT [Book Name] FROM Books WHERE [Book ID] = @BookID";
                parameter = tbBID.Text;
            }
            else if (!string.IsNullOrWhiteSpace(tbBN.Text))
            {
                query = "SELECT [Book ID] FROM Books WHERE [Book Name] = @BookName";
                parameter = tbBN.Text;
            }
            else return;

            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);

                if (!string.IsNullOrWhiteSpace(tbBID.Text))
                    cmd.Parameters.AddWithValue("@BookID", parameter);
                else
                    cmd.Parameters.AddWithValue("@BookName", parameter);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (!string.IsNullOrWhiteSpace(tbBID.Text))
                        tbBN.Text = reader["Book Name"].ToString();
                    else
                        tbBID.Text = reader["Book ID"].ToString();
                }
                else
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }




        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Inputs
                if (string.IsNullOrWhiteSpace(tbSID.Text) ||
                    string.IsNullOrWhiteSpace(tbBID.Text) ||
                    string.IsNullOrWhiteSpace(tbQ.Text))
                {
                    MessageBox.Show("Please fill all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentID = int.Parse(tbSID.Text);
                int bookID = int.Parse(tbBID.Text);
                int quantity = int.Parse(tbQ.Text);

                // Open Database Connection inside using statement
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb"))
                {
                    conn.Open();

                    // Check if the student exists in the Students table
                    OleDbCommand checkStudentCmd = new OleDbCommand("SELECT COUNT(*) FROM StudentList WHERE [Student ID] = @StudentID", conn);
                    checkStudentCmd.Parameters.AddWithValue("@StudentID", studentID);

                    int studentCount = (int)checkStudentCmd.ExecuteScalar();
                    if (studentCount == 0)
                    {
                        MessageBox.Show("Student not found in the system. Cannot borrow books.", "Student Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the book exists in the Books table
                    OleDbCommand checkBookCmd = new OleDbCommand("SELECT COUNT(*) FROM Books WHERE [Book ID] = @BookID", conn);
                    checkBookCmd.Parameters.AddWithValue("@BookID", bookID);

                    int bookCount = (int)checkBookCmd.ExecuteScalar();
                    if (bookCount == 0)
                    {
                        MessageBox.Show("Book not found in the system. Cannot borrow.", "Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check Book Availability (quantity in stock)
                    OleDbCommand checkStockCmd = new OleDbCommand("SELECT [Quantity] FROM Books WHERE [Book ID] = @BookID", conn);
                    checkStockCmd.Parameters.AddWithValue("@BookID", bookID);

                    int currentStock = (int)checkStockCmd.ExecuteScalar();
                    if (currentStock < quantity)
                    {
                        MessageBox.Show("Not enough stock available!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert into BooksBorrowed Table
                    OleDbCommand insertCmd = new OleDbCommand(
                        "INSERT INTO BooksBorrowed ([Student ID], [FullName], [Grade], [Section], [Contact], [Book ID], [Book Name], [Quantity], [Date Borrowed], [Date Returned], [Status]) " +
                        "VALUES (@StudentID, @FullName, @Grade, @Section, @Contact, @BookID, @BookName, @Quantity, @DateBorrow, @DateReturn, @Status)", conn);

                    insertCmd.Parameters.AddWithValue("@StudentID", tbSID.Text);
                    insertCmd.Parameters.AddWithValue("@FullName", tbFN.Text);
                    insertCmd.Parameters.AddWithValue("@Grade", tbG.Text);
                    insertCmd.Parameters.AddWithValue("@Section", tbS.Text);
                    insertCmd.Parameters.AddWithValue("@Contact", tbC.Text);
                    insertCmd.Parameters.AddWithValue("@BookID", bookID);
                    insertCmd.Parameters.AddWithValue("@BookName", tbBN.Text);
                    insertCmd.Parameters.AddWithValue("@Quantity", quantity); // Quantity value
                    insertCmd.Parameters.AddWithValue("@DateBorrow", DateTime.Now.ToShortDateString());
                    insertCmd.Parameters.AddWithValue("@DateReturn", DateTime.Now.AddDays(15).ToShortDateString());
                    insertCmd.Parameters.AddWithValue("@Status", "Ongoing");

                    insertCmd.ExecuteNonQuery();

                    // Update Books Table (Deduct Quantity)
                    OleDbCommand updateCmd = new OleDbCommand("UPDATE Books SET Quantity = Quantity - @Quantity WHERE [Book ID] = @BookID", conn);
                    updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateCmd.Parameters.AddWithValue("@BookID", bookID);

                    updateCmd.ExecuteNonQuery();

                    // If Quantity reaches 0, change status to Unavailable
                    OleDbCommand updateStatusCmd = new OleDbCommand("UPDATE Books SET Status = 'Unavailable' WHERE [Book ID] = @BookID AND Quantity = 0", conn);
                    updateStatusCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateStatusCmd.ExecuteNonQuery();

                    // Refresh DataGridView to show the latest borrowed books
                    LoadBorrowedBooks();

                    MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBorrowedBooks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbSID.Text = dgvBorrowedBooks.CurrentRow.Cells[1].Value.ToString();
            tbFN.Text = dgvBorrowedBooks.CurrentRow.Cells[2].Value.ToString();
            tbG.Text = dgvBorrowedBooks.CurrentRow.Cells[3].Value.ToString();
            tbS.Text = dgvBorrowedBooks.CurrentRow.Cells[4].Value.ToString();
            tbC.Text = dgvBorrowedBooks.CurrentRow.Cells[5].Value.ToString();
            tbBID.Text = dgvBorrowedBooks.CurrentRow.Cells[6].Value.ToString();
            tbBN.Text = dgvBorrowedBooks.CurrentRow.Cells[7].Value.ToString();
            tbQ.Text = dgvBorrowedBooks.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSID.Clear();
            tbFN.Clear();
            tbG.Clear();
            tbS.Clear();
            tbC.Clear();
            tbBID.Clear();
            tbBN.Clear();
            tbQ.Clear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb");
            try
            {
                // Validate that the necessary fields are not empty
                if (string.IsNullOrWhiteSpace(tbSID.Text) || string.IsNullOrWhiteSpace(tbBID.Text))
                {
                    MessageBox.Show("Please select a borrowed book to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentID = int.Parse(tbSID.Text);
                int bookID = int.Parse(tbBID.Text);

                // Open Database Connection
                conn.Open();

                // Get the BorrowID of the specific record to return
                OleDbCommand getBorrowIDCmd = new OleDbCommand("SELECT [Borrow ID], [Quantity] FROM BooksBorrowed WHERE [Student ID] = @StudentID AND [Book ID] = @BookID AND Status = 'Ongoing'", conn);
                getBorrowIDCmd.Parameters.AddWithValue("@StudentID", studentID);
                getBorrowIDCmd.Parameters.AddWithValue("@BookID", bookID);

                OleDbDataReader reader = getBorrowIDCmd.ExecuteReader();

                if (reader.Read())
                {
                    int borrowID = (int)reader["Borrow ID"];
                    int quantityReturned = (int)reader["Quantity"];
                    string dateReturned = DateTime.Now.ToShortDateString(); // Get the current date

                    // Update the status and date of the specific borrowed book record
                    OleDbCommand updateStatusCmd = new OleDbCommand(
                        "UPDATE BooksBorrowed SET Status = 'Returned', [Date Returned] = @DateReturned WHERE [Borrow ID] = @BorrowID", conn);
                    updateStatusCmd.Parameters.AddWithValue("@DateReturned", dateReturned);
                    updateStatusCmd.Parameters.AddWithValue("@BorrowID", borrowID);
                    updateStatusCmd.ExecuteNonQuery();

                    // Update the book stock by adding back the quantity of the returned book
                    OleDbCommand updateStockCmd = new OleDbCommand("UPDATE Books SET Quantity = Quantity + @Quantity WHERE [Book ID] = @BookID", conn);
                    updateStockCmd.Parameters.AddWithValue("@Quantity", quantityReturned);
                    updateStockCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateStockCmd.ExecuteNonQuery();

                    // If Quantity is greater than 0, change status to Available
                    OleDbCommand updateAvailabilityCmd = new OleDbCommand("UPDATE Books SET Status = 'Available' WHERE [Book ID] = @BookID AND Quantity > 0", conn);
                    updateAvailabilityCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show($"Book returned successfully on {dateReturned}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBorrowedBooks(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("No matching borrowed record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void ExportToPDF()
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                if (dgvBorrowedBooks.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Initialize a PDF document
                PdfDocument pdfDoc = new PdfDocument();
                pdfDoc.Info.Title = "Borrowed Books Report";
                PdfPage page = pdfDoc.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Fonts
                XFont titleFont = new XFont("Times New Roman", 16, XFontStyle.Bold);
                XFont labelFont = new XFont("Times New Roman", 12, XFontStyle.Bold);
                XFont dataFont = new XFont("Times New Roman", 10, XFontStyle.Regular);

                // Set margins
                double margin = 40;
                double top = 40;

                // Report title
                gfx.DrawString("Borrowed Books Report", titleFont, XBrushes.Black, new XPoint(margin, top));
                top += 30;

                // Report period (start and end dates)
                string startDate = dtpStartDate.Value.Date.ToShortDateString();
                string endDate = dtpEndDate.Value.Date.ToShortDateString();
                gfx.DrawString($"Start Date: {startDate}", labelFont, XBrushes.Black, new XPoint(margin, top));
                top += 20;
                gfx.DrawString($"End Date: {endDate}", labelFont, XBrushes.Black, new XPoint(margin, top));
                top += 30;

                // Set column headers
                double xPos = margin;
                gfx.DrawString("Student ID", labelFont, XBrushes.Black, new XPoint(xPos, top));
                xPos += 100;
                gfx.DrawString("Full Name", labelFont, XBrushes.Black, new XPoint(xPos, top));
                xPos += 150;
                gfx.DrawString("Book ID", labelFont, XBrushes.Black, new XPoint(xPos, top));
                xPos += 100;
                gfx.DrawString("Book Name", labelFont, XBrushes.Black, new XPoint(xPos, top));
                xPos += 150;
                gfx.DrawString("Quantity", labelFont, XBrushes.Black, new XPoint(xPos, top));
                xPos += 80;
                gfx.DrawString("Date Borrowed", labelFont, XBrushes.Black, new XPoint(xPos, top));

                // Move to the next row for data
                top += 20;
                xPos = margin;

                // Iterate over each row in the DataGridView and add the data to the PDF
                foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
                {
                    if (row.Cells[0].Value == null) continue; // Skip empty rows

                    string studentId = row.Cells["Student ID"].Value?.ToString() ?? "";
                    string fullName = row.Cells["FullName"].Value?.ToString() ?? "";
                    string bookId = row.Cells["Book ID"].Value?.ToString() ?? "";
                    string bookName = row.Cells["Book Name"].Value?.ToString() ?? "";
                    string quantity = row.Cells["Quantity"].Value?.ToString() ?? "";
                    string dateBorrowed = row.Cells["Date Borrowed"].Value?.ToString() ?? "";

                    gfx.DrawString(studentId, dataFont, XBrushes.Black, new XPoint(xPos, top));
                    xPos += 100;
                    gfx.DrawString(fullName, dataFont, XBrushes.Black, new XPoint(xPos, top));
                    xPos += 150;
                    gfx.DrawString(bookId, dataFont, XBrushes.Black, new XPoint(xPos, top));
                    xPos += 100;
                    gfx.DrawString(bookName, dataFont, XBrushes.Black, new XPoint(xPos, top));
                    xPos += 150;
                    gfx.DrawString(quantity, dataFont, XBrushes.Black, new XPoint(xPos, top));
                    xPos += 80;
                    gfx.DrawString(dateBorrowed, dataFont, XBrushes.Black, new XPoint(xPos, top));

                    // Move to the next row
                    top += 20;
                    xPos = margin;

                    // Add a new page if the current one is full
                    if (top > page.Height - margin)
                    {
                        page = pdfDoc.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        top = margin;
                    }
                }

                // Save the PDF to a file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save Report";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfDoc.Save(saveFileDialog.FileName);
                    MessageBox.Show("Report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshData()
        {
            try
            {
                conn.Open();

                // Query to load all data
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM BooksBorrowed", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBorrowedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void GenerateReport()
        {
            try
            {
                // Get the selected start and end dates
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                // Open database connection
                conn.Open();

                // Adjusted query to filter by 'Date Borrowed' only
                string query = "SELECT * FROM BooksBorrowed WHERE [Date Borrowed] >= @StartDate AND [Date Borrowed] <= @EndDate";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate.ToShortDateString());
                da.SelectCommand.Parameters.AddWithValue("@EndDate", endDate.ToShortDateString());

                // Fill a DataTable and bind it to the DataGridView
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBorrowedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books myForm = new Books();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentList myForm = new StudentList();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textBox1.Text.Trim();

                // Apply filter only if the DataGridView is bound to a DataTable
                if (dgvBorrowedBooks.DataSource is DataTable dt)
                {
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        // Filter by Student Name, Student ID, Book ID, or Book Name
                        dt.DefaultView.RowFilter =
                            $"[FullName] LIKE '%{searchValue}%' OR " +
                            $"CONVERT([Student ID], 'System.String') LIKE '%{searchValue}%' OR " +
                            $"CONVERT([Book ID], 'System.String') LIKE '%{searchValue}%' OR " +
                            $"[Book Name] LIKE '%{searchValue}%'";
                    }
                    else
                    {
                        // Clear the filter if search box is empty
                        dt.DefaultView.RowFilter = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile myForm = new Profile();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
