namespace Du_An_1
{
    partial class Dangky
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            comboBoxTrangThai = new ComboBox();
            label7 = new Label();
            button3 = new Button();
            button1 = new Button();
            comboBoxChucVu = new ComboBox();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            txtMaTK = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(5, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(866, 635);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Turquoise;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(comboBoxTrangThai);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(comboBoxChucVu);
            tabPage1.Controls.Add(txtMatKhau);
            tabPage1.Controls.Add(txtTaiKhoan);
            tabPage1.Controls.Add(txtMaTK);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(858, 602);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đăng Ký Tài khoản";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(715, 317);
            dataGridView1.TabIndex = 19;
            // 
            // comboBoxTrangThai
            // 
            comboBoxTrangThai.FormattingEnabled = true;
            comboBoxTrangThai.Items.AddRange(new object[] { "Hoạt Động", "Không Hoạt Động" });
            comboBoxTrangThai.Location = new Point(513, 43);
            comboBoxTrangThai.Name = "comboBoxTrangThai";
            comboBoxTrangThai.Size = new Size(169, 28);
            comboBoxTrangThai.TabIndex = 17;
            comboBoxTrangThai.Text = "Không Hoạt Động";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(410, 47);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 16;
            label7.Text = "Trạng thái";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(715, 213);
            button3.Name = "button3";
            button3.Size = new Size(111, 40);
            button3.TabIndex = 15;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(715, 45);
            button1.Name = "button1";
            button1.Size = new Size(111, 67);
            button1.TabIndex = 13;
            button1.Text = "Dăng ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRegister_Click;
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.Location = new Point(207, 193);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(169, 28);
            comboBoxChucVu.TabIndex = 12;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(207, 139);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(169, 27);
            txtMatKhau.TabIndex = 10;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(207, 88);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(169, 27);
            txtTaiKhoan.TabIndex = 9;
            // 
            // txtMaTK
            // 
            txtMaTK.Location = new Point(207, 44);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(169, 27);
            txtMaTK.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 197);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 6;
            label5.Text = "Chức Vụ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 141);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 91);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 47);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã TK";
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 649);
            Controls.Add(tabControl1);
            Name = "Dangky";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý Thông Tin và Điểm ";
            Load += RegisterForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private TextBox txtMaTK;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxTrangThai;
        private Label label7;
        private Button button3;
        private Button button1;
        private ComboBox comboBoxChucVu;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private DataGridView dataGridView1;
    }
}