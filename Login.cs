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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Connection string for Access Database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb;";
            string query = "SELECT * FROM Account WHERE Username = @username AND Password = @password";

            // Retrieve input values
            string username = tbUser.Text; // Username TextBox
            string password = tbPass.Text; // Password TextBox

            try
            {
                // Create connection and command
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Execute the query
                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) // Check if any rows are returned
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Books myForm = new Books();
                            this.Hide();
                            myForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                // Show the password by setting PasswordChar to an empty string
                tbPass.PasswordChar = '\0';
            }
            else
            {
                // Hide the password by setting PasswordChar to '*'
                tbPass.PasswordChar = '*';
            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPass myForm = new ForgotPass();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
