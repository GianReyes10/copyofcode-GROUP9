namespace LibraryManagementSystem
{
    partial class ForgotPass
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
            tbAnswer1 = new TextBox();
            tbAnswer2 = new TextBox();
            tbAnswer3 = new TextBox();
            btnLogin = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbAnswer1
            // 
            tbAnswer1.Location = new Point(367, 167);
            tbAnswer1.Name = "tbAnswer1";
            tbAnswer1.Size = new Size(186, 27);
            tbAnswer1.TabIndex = 0;
            tbAnswer1.TextChanged += tbAnswer1_TextChanged;
            // 
            // tbAnswer2
            // 
            tbAnswer2.Location = new Point(367, 214);
            tbAnswer2.Name = "tbAnswer2";
            tbAnswer2.Size = new Size(186, 27);
            tbAnswer2.TabIndex = 1;
            tbAnswer2.TextChanged += tbAnswer2_TextChanged;
            // 
            // tbAnswer3
            // 
            tbAnswer3.Location = new Point(367, 265);
            tbAnswer3.Name = "tbAnswer3";
            tbAnswer3.Size = new Size(186, 27);
            tbAnswer3.TabIndex = 2;
            tbAnswer3.TextChanged += tbAnswer3_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(450, 321);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(283, 321);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(244, 170);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "First Pet Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(244, 221);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 6;
            label2.Text = "Favorite Food";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(258, 272);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 7;
            label3.Text = "City Born In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(283, 53);
            label4.Name = "label4";
            label4.Size = new Size(229, 32);
            label4.TabIndex = 8;
            label4.Text = "Security Questions";
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(tbAnswer3);
            Controls.Add(tbAnswer2);
            Controls.Add(tbAnswer1);
            Name = "ForgotPass";
            Text = "ForgotPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAnswer1;
        private TextBox tbAnswer2;
        private TextBox tbAnswer3;
        private Button btnLogin;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}