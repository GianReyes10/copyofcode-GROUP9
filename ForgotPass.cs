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

namespace LibraryManagementSystem
{
    public partial class ForgotPass : Form
    {

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb";
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void tbAnswer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAnswer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string answer1 = tbAnswer1.Text.Trim();
            string answer2 = tbAnswer2.Text.Trim();
            string answer3 = tbAnswer3.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(answer1) || string.IsNullOrWhiteSpace(answer2) || string.IsNullOrWhiteSpace(answer3))
            {
                MessageBox.Show("Please answer all the security questions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Answer1, Answer2, Answer3 FROM ForgotPass WHERE ID = 1"; // Replace 1 with the actual user ID or criteria
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbAnswer1 = reader["Answer1"].ToString();
                                string dbAnswer2 = reader["Answer2"].ToString();
                                string dbAnswer3 = reader["Answer3"].ToString();

                                // Validate the answers
                                if (answer1.Equals(dbAnswer1, StringComparison.OrdinalIgnoreCase) &&
                                    answer2.Equals(dbAnswer2, StringComparison.OrdinalIgnoreCase) &&
                                    answer3.Equals(dbAnswer3, StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Answers verified. You may reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Redirect to reset password form
                                    Books resetForm = new Books(); // Create this form separately
                                    this.Hide();
                                    resetForm.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect answers. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No record found for the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

