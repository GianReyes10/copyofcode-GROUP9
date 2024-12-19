namespace LibraryManagementSystem
{
    partial class Borrow
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
            dgvBorrowedBooks = new DataGridView();
            tbSID = new TextBox();
            tbFN = new TextBox();
            tbG = new TextBox();
            tbS = new TextBox();
            tbBID = new TextBox();
            tbBN = new TextBox();
            tbQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnBorrow = new Button();
            btnClear = new Button();
            btnReturn = new Button();
            btnBooks = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            textBox1 = new TextBox();
            label9 = new Label();
            btnLogout = new Button();
            btnProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.AllowUserToAddRows = false;
            dgvBorrowedBooks.AllowUserToDeleteRows = false;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(181, 60);
            dgvBorrowedBooks.Margin = new Padding(3, 4, 3, 4);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.Size = new Size(507, 343);
            dgvBorrowedBooks.TabIndex = 0;
            dgvBorrowedBooks.CellEnter += dgvBorrowedBooks_CellEnter;
            // 
            // tbSID
            // 
            tbSID.Location = new Point(310, 421);
            tbSID.Margin = new Padding(3, 4, 3, 4);
            tbSID.Name = "tbSID";
            tbSID.Size = new Size(114, 27);
            tbSID.TabIndex = 1;
            // 
            // tbFN
            // 
            tbFN.Location = new Point(310, 460);
            tbFN.Margin = new Padding(3, 4, 3, 4);
            tbFN.Name = "tbFN";
            tbFN.Size = new Size(114, 27);
            tbFN.TabIndex = 2;
            // 
            // tbG
            // 
            tbG.Location = new Point(310, 499);
            tbG.Margin = new Padding(3, 4, 3, 4);
            tbG.Name = "tbG";
            tbG.Size = new Size(114, 27);
            tbG.TabIndex = 3;
            // 
            // tbS
            // 
            tbS.Location = new Point(310, 537);
            tbS.Margin = new Padding(3, 4, 3, 4);
            tbS.Name = "tbS";
            tbS.Size = new Size(114, 27);
            tbS.TabIndex = 4;
            // 
            // tbBID
            // 
            tbBID.Location = new Point(559, 460);
            tbBID.Margin = new Padding(3, 4, 3, 4);
            tbBID.Name = "tbBID";
            tbBID.Size = new Size(114, 27);
            tbBID.TabIndex = 5;
            // 
            // tbBN
            // 
            tbBN.Location = new Point(559, 499);
            tbBN.Margin = new Padding(3, 4, 3, 4);
            tbBN.Name = "tbBN";
            tbBN.Size = new Size(114, 27);
            tbBN.TabIndex = 6;
            // 
            // tbQ
            // 
            tbQ.Location = new Point(559, 537);
            tbQ.Margin = new Padding(3, 4, 3, 4);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(114, 27);
            tbQ.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 425);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 8;
            label1.Text = "Student ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 471);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 9;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 509);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 541);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 11;
            label4.Text = "Section";
            // 
            // tbC
            // 
            tbC.Location = new Point(559, 421);
            tbC.Margin = new Padding(3, 4, 3, 4);
            tbC.Name = "tbC";
            tbC.Size = new Size(114, 27);
            tbC.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 464);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 13;
            label5.Text = "Book ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 503);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 14;
            label6.Text = "Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 541);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 15;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 425);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 16;
            label8.Text = "Contact";
            label8.Click += label8_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(713, 421);
            btnBorrow.Margin = new Padding(3, 4, 3, 4);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(79, 35);
            btnBorrow.TabIndex = 17;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(713, 471);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(79, 35);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(713, 513);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(79, 35);
            btnReturn.TabIndex = 19;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(37, 253);
            btnBooks.Margin = new Padding(3, 4, 3, 4);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(79, 35);
            btnBooks.TabIndex = 20;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(694, 94);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(98, 27);
            dtpStartDate.TabIndex = 21;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(813, 94);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(98, 27);
            dtpEndDate.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(735, 175);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 31);
            button1.TabIndex = 23;
            button1.Text = "Generate Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(735, 236);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 31);
            button2.TabIndex = 24;
            button2.Text = "Export Report";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(735, 297);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(120, 31);
            button3.TabIndex = 25;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(37, 314);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(79, 35);
            button4.TabIndex = 26;
            button4.Text = "Students";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 573);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SteelBlue;
            pictureBox2.Image = Properties.Resources.logo__2__removebg_preview;
            pictureBox2.Location = new Point(4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button5.Location = new Point(37, 368);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(79, 35);
            button5.TabIndex = 29;
            button5.Text = "Borrow";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 30;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(203, 23);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 31;
            label9.Text = "Search";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(37, 488);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(79, 35);
            btnLogout.TabIndex = 32;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(37, 158);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(79, 35);
            btnProfile.TabIndex = 33;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // Borrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnProfile);
            Controls.Add(btnLogout);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnBooks);
            Controls.Add(btnReturn);
            Controls.Add(btnClear);
            Controls.Add(btnBorrow);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbC);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbQ);
            Controls.Add(tbBN);
            Controls.Add(tbBID);
            Controls.Add(tbS);
            Controls.Add(tbG);
            Controls.Add(tbFN);
            Controls.Add(tbSID);
            Controls.Add(dgvBorrowedBooks);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Borrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow";
            Load += Borrow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private TextBox tbSID;
        private TextBox tbFN;
        private TextBox tbG;
        private TextBox tbS;
        private TextBox tbBID;
        private TextBox tbBN;
        private TextBox tbQ;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbC;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnBorrow;
        private Button btnClear;
        private Button btnReturn;
        private Button btnBooks;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button5;
        private TextBox textBox1;
        private Label label9;
        private Button btnLogout;
        private Button btnProfile;
    }
}