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


    public partial class Profile : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gianr\OneDrive\Desktop\LibrarySystem\LibrarySystem.accdb";

        public Profile()
        {
            InitializeComponent();
            LoadProfile();
            LoadSecurityQuestions();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(tbUser.Text) || string.IsNullOrWhiteSpace(tbPass.Text) ||
                string.IsNullOrWhiteSpace(tbRePass.Text) || string.IsNullOrWhiteSpace(tbAnswer1.Text) ||
                string.IsNullOrWhiteSpace(tbAnswer2.Text) || string.IsNullOrWhiteSpace(tbAnswer3.Text))
            {
                MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbPass.Text != tbRePass.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Update Account table
                    string accountQuery = "UPDATE Account SET [Username] = ?, [Password] = ? WHERE ID = 1"; // Replace 1 with logged-in user ID
                    using (OleDbCommand accountCmd = new OleDbCommand(accountQuery, conn))
                    {
                        accountCmd.Parameters.AddWithValue("?", tbUser.Text);
                        accountCmd.Parameters.AddWithValue("?", tbPass.Text);
                        accountCmd.ExecuteNonQuery();
                    }

                    // Update ForgotPass table
                    string forgotPassQuery = "UPDATE ForgotPass SET [Answer1] = ?, [Answer2] = ?, [Answer3] = ? WHERE ID = 1"; // Replace 1 with logged-in user ID
                    using (OleDbCommand forgotPassCmd = new OleDbCommand(forgotPassQuery, conn))
                    {
                        forgotPassCmd.Parameters.AddWithValue("?", tbAnswer1.Text);
                        forgotPassCmd.Parameters.AddWithValue("?", tbAnswer2.Text);
                        forgotPassCmd.Parameters.AddWithValue("?", tbAnswer3.Text);
                        forgotPassCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Lock fields again after successful update
                    ToggleFields(false);
                    ToggleSecurityFields(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRePass_TextChanged(object sender, EventArgs e)
        {

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
        private void ToggleSecurityFields(bool enable)
        {
            tbAnswer1.ReadOnly = !enable;
            tbAnswer2.ReadOnly = !enable;
            tbAnswer3.ReadOnly = !enable;
        }
        private void LoadSecurityQuestions()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Answer1, Answer2, Answer3 FROM ForgotPass WHERE ID = 1"; // Replace 1 with logged-in user ID
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbAnswer1.Text = reader["Answer1"].ToString();
                                tbAnswer2.Text = reader["Answer2"].ToString();
                                tbAnswer3.Text = reader["Answer3"].ToString();
                            }
                        }
                    }
                }

                ToggleSecurityFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading security questions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProfile()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Username, Password FROM Account WHERE ID = 1"; // Replace 1 with the logged-in user ID
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbUser.Text = reader["Username"].ToString();
                                tbPass.Text = reader["Password"].ToString();
                                tbRePass.Text = reader["Password"].ToString();
                            }
                        }
                    }
                }

                // Initially, make the textboxes read-only
                ToggleFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleFields(bool enable)
        {
            tbUser.ReadOnly = !enable;
            tbPass.ReadOnly = !enable;
            tbRePass.ReadOnly = !enable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleFields(true);
            ToggleSecurityFields(true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Books resetForm = new Books(); // Create this form separately
            this.Hide();
            resetForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

