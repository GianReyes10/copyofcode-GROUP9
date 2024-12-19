namespace LibraryManagementSystem
{
    partial class Books
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBooks = new DataGridView();
            tbBID = new TextBox();
            tbBN = new TextBox();
            tbBA = new TextBox();
            tbQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnBorrow = new Button();
            btnStudents = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            btnLogout = new Button();
            btnProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(272, 49);
            dgvBooks.Margin = new Padding(3, 4, 3, 4);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(498, 331);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellEnter += dgvBooks_CellEnter;
            // 
            // tbBID
            // 
            tbBID.Location = new Point(272, 432);
            tbBID.Margin = new Padding(3, 4, 3, 4);
            tbBID.Name = "tbBID";
            tbBID.ReadOnly = true;
            tbBID.Size = new Size(114, 27);
            tbBID.TabIndex = 1;
            // 
            // tbBN
            // 
            tbBN.Location = new Point(272, 471);
            tbBN.Margin = new Padding(3, 4, 3, 4);
            tbBN.Name = "tbBN";
            tbBN.Size = new Size(114, 27);
            tbBN.TabIndex = 13;
            // 
            // tbBA
            // 
            tbBA.Location = new Point(272, 509);
            tbBA.Margin = new Padding(3, 4, 3, 4);
            tbBA.Name = "tbBA";
            tbBA.Size = new Size(114, 27);
            tbBA.TabIndex = 3;
            // 
            // tbQ
            // 
            tbQ.Location = new Point(472, 432);
            tbQ.Margin = new Padding(3, 4, 3, 4);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(114, 27);
            tbQ.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 443);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 481);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 520);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 7;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 436);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(638, 432);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(638, 481);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(742, 432);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.Yes;
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(742, 481);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(47, 349);
            btnBorrow.Margin = new Padding(3, 4, 3, 4);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(86, 31);
            btnBorrow.TabIndex = 0;
            btnBorrow.Text = "Borrow";
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(47, 300);
            btnStudents.Margin = new Padding(3, 4, 3, 4);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(86, 31);
            btnStudents.TabIndex = 14;
            btnStudents.Text = "Students";
            btnStudents.Click += btnStudents_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(-1, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 580);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SteelBlue;
            pictureBox2.Image = Properties.Resources.logo__2__removebg_preview;
            pictureBox2.Location = new Point(-1, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.Location = new Point(47, 251);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 17;
            button1.Text = "Books";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 25);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 18;
            label5.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(47, 470);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(47, 180);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(86, 31);
            btnProfile.TabIndex = 21;
            btnProfile.Text = "Profile";
            btnProfile.Click += btnProfile_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnProfile);
            Controls.Add(btnLogout);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(btnStudents);
            Controls.Add(btnBorrow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbQ);
            Controls.Add(tbBA);
            Controls.Add(tbBN);
            Controls.Add(tbBID);
            Controls.Add(dgvBooks);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Borrow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private TextBox tbBID;
        private TextBox tbBN;
        private TextBox tbBA;
        private TextBox tbQ;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnBorrow;
        private Button btnStudents;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label5;
        private TextBox textBox1;
        private Button btnLogout;
        private Button btnProfile;
    }
}
