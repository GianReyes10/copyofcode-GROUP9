namespace LibraryManagementSystem
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            tbUser = new TextBox();
            tbPass = new TextBox();
            tbRePass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            btnLogout = new Button();
            tbAnswer1 = new TextBox();
            label4 = new Label();
            tbAnswer2 = new TextBox();
            tbAnswer3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnEdit = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(51, 31);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(219, 133);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(214, 27);
            tbUser.TabIndex = 1;
            tbUser.TextChanged += tbUser_TextChanged;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(219, 201);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(214, 27);
            tbPass.TabIndex = 2;
            tbPass.TextChanged += tbPass_TextChanged;
            // 
            // tbRePass
            // 
            tbRePass.Location = new Point(219, 262);
            tbRePass.Name = "tbRePass";
            tbRePass.Size = new Size(214, 27);
            tbRePass.TabIndex = 3;
            tbRePass.TextChanged += tbRePass_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 20;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(63, 269);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 6;
            label3.Text = "Re-enter Password";
            label3.Click += label3_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(316, 334);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(763, 409);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(106, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tbAnswer1
            // 
            tbAnswer1.Location = new Point(628, 133);
            tbAnswer1.Name = "tbAnswer1";
            tbAnswer1.Size = new Size(174, 27);
            tbAnswer1.TabIndex = 9;
            tbAnswer1.TextChanged += tbAnswer1_TextChanged;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 18;
            // 
            // tbAnswer2
            // 
            tbAnswer2.Location = new Point(628, 197);
            tbAnswer2.Name = "tbAnswer2";
            tbAnswer2.Size = new Size(174, 27);
            tbAnswer2.TabIndex = 11;
            tbAnswer2.TextChanged += tbAnswer2_TextChanged;
            // 
            // tbAnswer3
            // 
            tbAnswer3.Location = new Point(628, 259);
            tbAnswer3.Name = "tbAnswer3";
            tbAnswer3.Size = new Size(174, 27);
            tbAnswer3.TabIndex = 12;
            tbAnswer3.TextChanged += tbAnswer3_TextChanged;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(521, 262);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 14;
            label6.Text = "City Born in";
            label6.Click += label6_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(480, 334);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 29);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(393, 18);
            label7.Name = "label7";
            label7.Size = new Size(116, 41);
            label7.TabIndex = 16;
            label7.Text = "Profile";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(128, 204);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 21;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(124, 136);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 22;
            label9.Text = "Username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(507, 140);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 23;
            label10.Text = "First Pet Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(507, 201);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 24;
            label11.Text = "Favorite Food";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbAnswer3);
            Controls.Add(tbAnswer2);
            Controls.Add(label4);
            Controls.Add(tbAnswer1);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbRePass);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(btnBack);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private TextBox tbUser;
        private TextBox tbPass;
        private TextBox tbRePass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnUpdate;
        private Button btnLogout;
        private TextBox tbAnswer1;
        private Label label4;
        private TextBox tbAnswer2;
        private TextBox tbAnswer3;
        private Label label5;
        private Label label6;
        private Button btnEdit;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}