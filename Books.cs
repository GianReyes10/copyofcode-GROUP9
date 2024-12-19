using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;





namespace LibraryManagementSystem
{
    public partial class Books : Form
    {

        string connString = @"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb";
        OleDbConnection conn;

        public Books()
        {
            InitializeComponent();
            conn = new OleDbConnection(connString);
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            try
            {
                // SQL Query to Retrieve All Books
                string query = "SELECT * FROM Books";

                // Use 'using' to ensure proper connection handling
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();  // Open the connection

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                    // Fill DataTable with data from database
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);

                    // Bind DataTable to DataGridView
                    dgvBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AddBook()
        {
            try
            {
                // Correct SQL Query with Brackets for Field Names
                string query = "INSERT INTO Books ([Book Name], [Author], [Quantity], [Date Submitted], [Date Updated], [Status]) " +
                               "VALUES (@BookName, @Author, @Quantity, @DateSubmitted, @DateUpdated, @Status)";

                // Use 'using' to ensure proper connection handling
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();  // Open the connection

                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    // Assign values from form controls
                    cmd.Parameters.AddWithValue("@BookName", tbBN.Text);
                    cmd.Parameters.AddWithValue("@Author", tbBA.Text);
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(tbQ.Text));
                    cmd.Parameters.AddWithValue("@DateSubmitted", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Status", "Available");

                    // Execute query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully!");

                    // Clear form and refresh grid
                    ClearForm();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            tbBN.Text = "";
            tbBA.Text = "";
            tbQ.Text = "";
            tbBID.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(tbBN.Text) ||
                string.IsNullOrWhiteSpace(tbBA.Text) ||
                string.IsNullOrWhiteSpace(tbQ.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Call AddBook function
            AddBook();
        }

        private void dgvBooks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbBN.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            tbBID.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            tbBA.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            tbQ.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if the Book ID (tbBID) is filled, which ensures a book is selected for updating
            if (string.IsNullOrWhiteSpace(tbBID.Text) ||
                string.IsNullOrWhiteSpace(tbBN.Text) ||
                string.IsNullOrWhiteSpace(tbBA.Text) ||
                string.IsNullOrWhiteSpace(tbQ.Text))
            {
                MessageBox.Show("Please fill in all fields and select a book to update.");
                return;
            }

            try
            {
                // SQL Query to Update Book details
                string query = "UPDATE Books SET [Book Name] = @BookName, [Author] = @Author, [Quantity] = @Quantity, [Date Updated] = @DateUpdated, [Status] = @Status " +
                               "WHERE [Book ID] = @BookID";

                // Use 'using' to ensure proper connection handling
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();  // Open the connection

                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    // Assign values from form controls
                    cmd.Parameters.AddWithValue("@BookName", tbBN.Text);
                    cmd.Parameters.AddWithValue("@Author", tbBA.Text);
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(tbQ.Text));
                    cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Status", "Available");
                    cmd.Parameters.AddWithValue("@BookID", int.Parse(tbBID.Text)); // Book ID for update condition

                    // Execute query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully!");

                    // Clear form and refresh grid
                    ClearForm();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure the Book ID is not empty, i.e., a book is selected
            if (string.IsNullOrWhiteSpace(tbBID.Text))
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            // Confirm deletion with the user
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // SQL Query to Delete the Book
                    string query = "DELETE FROM Books WHERE [Book ID] = @BookID";

                    // Use 'using' to ensure proper connection handling
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();  // Open the connection

                        OleDbCommand cmd = new OleDbCommand(query, conn);

                        // Assign the Book ID parameter
                        cmd.Parameters.AddWithValue("@BookID", int.Parse(tbBID.Text)); // Book ID for deletion condition

                        // Execute the delete query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book deleted successfully!");

                        // Clear the form and refresh the grid
                        ClearForm();
                        LoadBooks();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow myForm = new Borrow();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentList myForm = new StudentList();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textBox1.Text.Trim();

                // Apply filter to the DataGridView based on Book Name or Author or Book ID
                if (dgvBooks.DataSource is DataTable dt)
                {
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        // Filter the DataTable based on Book Name, Author, or Book ID
                        dt.DefaultView.RowFilter = $"[Book Name] LIKE '%{searchValue}%' OR [Author] LIKE '%{searchValue}%' OR CONVERT([Book ID], 'System.String') LIKE '%{searchValue}%'";
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = ""; // Clear the filter
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
