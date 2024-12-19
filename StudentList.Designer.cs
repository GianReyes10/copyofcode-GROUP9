namespace LibraryManagementSystem
{
    partial class StudentList
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
            dgvStudentsList = new DataGridView();
            tbFN = new TextBox();
            tbG = new TextBox();
            tbS = new TextBox();
            tbC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnImport = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            btnLogout = new Button();
            btnProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentsList
            // 
            dgvStudentsList.AllowUserToAddRows = false;
            dgvStudentsList.AllowUserToDeleteRows = false;
            dgvStudentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentsList.Location = new Point(273, 56);
            dgvStudentsList.Margin = new Padding(3, 4, 3, 4);
            dgvStudentsList.Name = "dgvStudentsList";
            dgvStudentsList.ReadOnly = true;
            dgvStudentsList.RowHeadersWidth = 51;
            dgvStudentsList.Size = new Size(577, 288);
            dgvStudentsList.TabIndex = 0;
            dgvStudentsList.CellContentClick += dgvStudentsList_CellContentClick;
            dgvStudentsList.CellEnter += dgvStudentsList_CellEnter;
            // 
            // tbFN
            // 
            tbFN.Location = new Point(288, 372);
            tbFN.Margin = new Padding(3, 4, 3, 4);
            tbFN.Name = "tbFN";
            tbFN.Size = new Size(135, 27);
            tbFN.TabIndex = 1;
            // 
            // tbG
            // 
            tbG.Location = new Point(288, 428);
            tbG.Margin = new Padding(3, 4, 3, 4);
            tbG.Name = "tbG";
            tbG.Size = new Size(135, 27);
            tbG.TabIndex = 2;
            // 
            // tbS
            // 
            tbS.Location = new Point(288, 485);
            tbS.Margin = new Padding(3, 4, 3, 4);
            tbS.Name = "tbS";
            tbS.Size = new Size(135, 27);
            tbS.TabIndex = 3;
            // 
            // tbC
            // 
            tbC.Location = new Point(288, 541);
            tbC.Margin = new Padding(3, 4, 3, 4);
            tbC.Name = "tbC";
            tbC.Size = new Size(135, 27);
            tbC.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(211, 376);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(224, 432);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 6;
            label2.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(224, 489);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "Section";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(224, 545);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Contact";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(582, 372);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(582, 411);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(582, 449);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(582, 488);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(582, 527);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(86, 31);
            btnImport.TabIndex = 13;
            btnImport.Text = "IMPORT";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(45, 235);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 14;
            button1.Text = "Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 333);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 15;
            button2.Text = "Borrow";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SteelBlue;
            pictureBox2.Location = new Point(-4, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 592);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Image = Properties.Resources.logo__2__removebg_preview;
            pictureBox1.Location = new Point(45, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button3.Location = new Point(45, 284);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 19;
            button3.Text = "Student";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 29);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 21;
            label5.Text = "Search";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(50, 474);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(81, 35);
            btnLogout.TabIndex = 22;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(50, 163);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(81, 35);
            btnProfile.TabIndex = 23;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(btnProfile);
            Controls.Add(btnLogout);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnImport);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbC);
            Controls.Add(tbS);
            Controls.Add(tbG);
            Controls.Add(tbFN);
            Controls.Add(dgvStudentsList);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentList";
            Load += StudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentsList;
        private TextBox tbFN;
        private TextBox tbG;
        private TextBox tbS;
        private TextBox tbC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnImport;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button3;
        private TextBox textBox1;
        private Label label5;
        private Button btnLogout;
        private Button btnProfile;
    }
}