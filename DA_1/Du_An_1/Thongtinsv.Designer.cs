namespace Du_An_1
{
    partial class Thongtinsv
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
            btnThoat = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtDiaChi = new TextBox();
            label8 = new Label();
            datNgaySinh = new Label();
            dgvTTSinhVien = new DataGridView();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            txtMasv = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTTSinhVien).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(947, 558);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Turquoise;
            tabPage1.Controls.Add(btnThoat);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(txtDiaChi);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(datNgaySinh);
            tabPage1.Controls.Add(dgvTTSinhVien);
            tabPage1.Controls.Add(txtSDT);
            tabPage1.Controls.Add(txtTen);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtMasv);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(939, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin Sinh Viên";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(812, 266);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 90;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(698, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 27);
            dateTimePicker1.TabIndex = 89;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(683, 200);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(236, 27);
            txtDiaChi.TabIndex = 88;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(768, 178);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 87;
            label8.Text = "Quê Quán";
            // 
            // datNgaySinh
            // 
            datNgaySinh.AutoSize = true;
            datNgaySinh.Location = new Point(780, 83);
            datNgaySinh.Name = "datNgaySinh";
            datNgaySinh.Size = new Size(76, 20);
            datNgaySinh.TabIndex = 86;
            datNgaySinh.Text = "Ngay Sinh";
            // 
            // dgvTTSinhVien
            // 
            dgvTTSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTTSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTTSinhVien.Location = new Point(19, 328);
            dgvTTSinhVien.Name = "dgvTTSinhVien";
            dgvTTSinhVien.RowHeadersWidth = 51;
            dgvTTSinhVien.RowTemplate.Height = 29;
            dgvTTSinhVien.Size = new Size(887, 188);
            dgvTTSinhVien.TabIndex = 85;
            dgvTTSinhVien.CurrentCellChanged += dgvTTSinhVien_CurrentCellChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(376, 200);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(236, 27);
            txtSDT.TabIndex = 84;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(376, 106);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(236, 27);
            txtTen.TabIndex = 83;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(49, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(244, 27);
            txtEmail.TabIndex = 81;
            // 
            // txtMasv
            // 
            txtMasv.Location = new Point(49, 106);
            txtMasv.Name = "txtMasv";
            txtMasv.ReadOnly = true;
            txtMasv.Size = new Size(244, 27);
            txtMasv.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 178);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 79;
            label6.Text = "So Dien Thoai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 83);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 78;
            label5.Text = "Ten HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 178);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 76;
            label2.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 83);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 75;
            label4.Text = "Ma HS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 47);
            label1.TabIndex = 74;
            label1.Text = "Thông Tin Học Sinh";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Turquoise;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(939, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thông Tin Lớp";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(836, 443);
            dataGridView1.TabIndex = 0;
            // 
            // Thongtinsv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(953, 572);
            Controls.Add(tabControl1);
            Name = "Thongtinsv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý Thông Tin và Điểm ";
            Load += Thongtinsv_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTTSinhVien).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnThoat;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDiaChi;
        private Label label8;
        private Label datNgaySinh;
        private DataGridView dgvTTSinhVien;
        private TextBox txtSDT;
        private TextBox txtTen;
        private TextBox txtEmail;
        private TextBox txtMasv;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
    }
}