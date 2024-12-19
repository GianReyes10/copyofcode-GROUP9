namespace LibraryManagementSystem
{
    partial class Login
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
            tbUser = new TextBox();
            tbPass = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cbShowPass = new CheckBox();
            btnForgotPass = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbUser
            // 
            tbUser.Location = new Point(294, 214);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(206, 27);
            tbUser.TabIndex = 0;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(294, 267);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(206, 27);
            tbPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(335, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 32);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 191);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 244);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo__2__removebg_preview;
            pictureBox1.Location = new Point(318, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Location = new Point(506, 269);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(132, 24);
            cbShowPass.TabIndex = 6;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // btnForgotPass
            // 
            btnForgotPass.Location = new Point(318, 364);
            btnForgotPass.Name = "btnForgotPass";
            btnForgotPass.Size = new Size(143, 33);
            btnForgotPass.TabIndex = 7;
            btnForgotPass.Text = "Forgot Password";
            btnForgotPass.UseVisualStyleBackColor = true;
            btnForgotPass.Click += btnForgotPass_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(289, 139);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 8;
            label3.Text = "Library Management System";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnForgotPass);
            Controls.Add(cbShowPass);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUser;
        private TextBox tbPass;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox cbShowPass;
        private Button btnForgotPass;
        private Label label3;
    }
}