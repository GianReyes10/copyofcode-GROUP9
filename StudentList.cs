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
using ExcelDataReader;

namespace LibraryManagementSystem
{
    public partial class StudentList : Form
    {
        private OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb");
        public StudentList()
        {

            InitializeComponent();
            this.Load += StudentList_Load;
            // Ensure the Update button is hooked

        }

        private void dgvStudentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadStudentList();
        }


        private void LoadStudentList()
        {
            try
            {
                // Open Database Connection
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb"))
                {
                    conn.Open();

                    // Fetch Students Data
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT [Student ID], [FullName], [Grade], [Section], [Contact] FROM StudentList", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind Data to DataGridView
                    dgvStudentsList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbFN.Text) ||
                    string.IsNullOrWhiteSpace(tbG.Text) ||
                    string.IsNullOrWhiteSpace(tbS.Text) ||
                    string.IsNullOrWhiteSpace(tbC.Text))
                {
                    MessageBox.Show("Please fill all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullName = tbFN.Text;
                string grade = tbG.Text;
                string section = tbS.Text;
                string contact = tbC.Text;

                // Grade Validation
                if (int.TryParse(grade, out int gradeValue) && gradeValue > 10)
                {
                    MessageBox.Show("Grade cannot be greater than 10. Please enter a valid grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb"))
                {
                    conn.Open();

                    OleDbCommand insertCmd = new OleDbCommand(
                        "INSERT INTO StudentList ([FullName], [Grade], [Section], [Contact]) VALUES (@FullName, @Grade, @Section, @Contact)", conn);

                    insertCmd.Parameters.AddWithValue("@FullName", fullName);
                    insertCmd.Parameters.AddWithValue("@Grade", grade);
                    insertCmd.Parameters.AddWithValue("@Section", section);
                    insertCmd.Parameters.AddWithValue("@Contact", contact);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudentsList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbFN.Text = dgvStudentsList.CurrentRow.Cells[1].Value.ToString();
            tbG.Text = dgvStudentsList.CurrentRow.Cells[2].Value.ToString();
            tbS.Text = dgvStudentsList.CurrentRow.Cells[3].Value.ToString();
            tbC.Text = dgvStudentsList.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            tbFN.Clear();
            tbG.Clear();
            tbS.Clear();
            tbC.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that a student is selected from the DataGridView
                if (dgvStudentsList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected Student ID
                int studentID = Convert.ToInt32(dgvStudentsList.SelectedRows[0].Cells[0].Value); // Assuming Student ID is in the first column

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // Open Database Connection
                    using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb"))
                    {
                        conn.Open();

                        // Delete student from StudentList table
                        OleDbCommand deleteCmd = new OleDbCommand("DELETE FROM StudentList WHERE [Student ID] = @StudentID", conn);
                        deleteCmd.Parameters.AddWithValue("@StudentID", studentID);

                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to show the updated student list
                        LoadStudentList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImportToDatabase(DataTable dt)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb"))
                {
                    conn.Open();

                    foreach (DataRow row in dt.Rows)
                    {
                        // Grade Validation
                        if (int.TryParse(row["Grade"].ToString(), out int gradeValue) && gradeValue > 10)
                        {
                            MessageBox.Show($"Skipping entry with FullName '{row["FullName"]}' because Grade is greater than 10.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue; // Skip this row
                        }

                        OleDbCommand cmd = new OleDbCommand(
                            "INSERT INTO StudentList ([FullName], [Grade], [Section], [Contact]) VALUES (@FullName, @Grade, @Section, @Contact)", conn);

                        cmd.Parameters.AddWithValue("@FullName", row["FullName"].ToString());
                        cmd.Parameters.AddWithValue("@Grade", row["Grade"].ToString());
                        cmd.Parameters.AddWithValue("@Section", row["Section"].ToString());
                        cmd.Parameters.AddWithValue("@Contact", row["Contact"].ToString());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting data into database: " + ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbFN.Text) ||
                    string.IsNullOrWhiteSpace(tbG.Text) ||
                    string.IsNullOrWhiteSpace(tbS.Text) ||
                    string.IsNullOrWhiteSpace(tbC.Text))
                {
                    MessageBox.Show("Please fill all required fields to update the student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvStudentsList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentID = Convert.ToInt32(dgvStudentsList.SelectedRows[0].Cells[0].Value);
                string fullName = tbFN.Text;
                string grade = tbG.Text;
                string section = tbS.Text;
                string contact = tbC.Text;

                // Grade Validation
                if (int.TryParse(grade, out int gradeValue) && gradeValue > 10)
                {
                    MessageBox.Show("Grade cannot be greater than 10. Please enter a valid grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb"))
                {
                    conn.Open();

                    OleDbCommand updateCmd = new OleDbCommand(
                        "UPDATE StudentList SET [FullName] = @FullName, [Grade] = @Grade, [Section] = @Section, [Contact] = @Contact WHERE [Student ID] = @StudentID", conn);

                    updateCmd.Parameters.AddWithValue("@FullName", fullName);
                    updateCmd.Parameters.AddWithValue("@Grade", grade);
                    updateCmd.Parameters.AddWithValue("@Section", section);
                    updateCmd.Parameters.AddWithValue("@Contact", contact);
                    updateCmd.Parameters.AddWithValue("@StudentID", studentID);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                // Open File Dialog to Select Excel File
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Excel Files|*.xls;*.xlsx;",
                    Title = "Select an Excel File"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load DataTable from the Excel File
                    DataTable dt = ReadExcelFile(ofd.FileName);

                    // Insert DataTable into the Database
                    ImportToDatabase(dt);

                    // Refresh the GridView
                    LoadStudentList();

                    MessageBox.Show("Excel file imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private DataTable ReadExcelFile(string filePath)
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance); // Register Encoding for ExcelDataReader

                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        // Use First Row as Header
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true // Treat First Row as Header
                            }
                        });

                        // Return the first table (assuming single sheet)
                        return result.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading Excel file: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books myForm = new Books();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Borrow myForm = new Borrow();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textBox1.Text.Trim();

                // Apply filter to the DataGridView based on FullName or Student ID
                if (dgvStudentsList.DataSource is DataTable dt)
                {
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        dt.DefaultView.RowFilter = $"[FullName] LIKE '%{searchValue}%' OR CONVERT([Student ID], 'System.String') LIKE '%{searchValue}%'";
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


