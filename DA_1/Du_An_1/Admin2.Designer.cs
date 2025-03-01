namespace Du_An_1
{
    partial class Admin2
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
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TbxMaTK = new TextBox();
            TbxTenGV = new TextBox();
            TbxSDT = new TextBox();
            TbxEmail = new TextBox();
            TbxMaGV = new TextBox();
            dgvGiangVien = new DataGridView();
            txbMatk = new DataGridViewTextBoxColumn();
            txbMagv = new DataGridViewTextBoxColumn();
            txbTengv = new DataGridViewTextBoxColumn();
            txbNgaysinh = new DataGridViewTextBoxColumn();
            Gioi_tinh = new DataGridViewTextBoxColumn();
            txbemail = new DataGridViewTextBoxColumn();
            Txbsdt = new DataGridViewTextBoxColumn();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(275, 56);
            label1.Name = "label1";
            label1.Size = new Size(348, 47);
            label1.TabIndex = 1;
            label1.Text = "Thông Tin Giáo Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 152);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 9;
            label4.Text = "Mã TK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 235);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 10;
            label2.Text = "TênGV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 319);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 11;
            label3.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 152);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 235);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 13;
            label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(131, 319);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 14;
            label7.Text = "MãGV";
            // 
            // TbxMaTK
            // 
            TbxMaTK.Location = new Point(52, 175);
            TbxMaTK.Name = "TbxMaTK";
            TbxMaTK.ReadOnly = true;
            TbxMaTK.Size = new Size(211, 27);
            TbxMaTK.TabIndex = 15;
            // 
            // TbxTenGV
            // 
            TbxTenGV.Location = new Point(52, 258);
            TbxTenGV.Name = "TbxTenGV";
            TbxTenGV.ReadOnly = true;
            TbxTenGV.Size = new Size(211, 27);
            TbxTenGV.TabIndex = 16;
            // 
            // TbxSDT
            // 
            TbxSDT.Location = new Point(363, 342);
            TbxSDT.Name = "TbxSDT";
            TbxSDT.ReadOnly = true;
            TbxSDT.Size = new Size(211, 27);
            TbxSDT.TabIndex = 17;
            // 
            // TbxEmail
            // 
            TbxEmail.Location = new Point(363, 175);
            TbxEmail.Name = "TbxEmail";
            TbxEmail.ReadOnly = true;
            TbxEmail.Size = new Size(211, 27);
            TbxEmail.TabIndex = 18;
            // 
            // TbxMaGV
            // 
            TbxMaGV.Location = new Point(52, 342);
            TbxMaGV.Name = "TbxMaGV";
            TbxMaGV.ReadOnly = true;
            TbxMaGV.Size = new Size(211, 27);
            TbxMaGV.TabIndex = 20;
            // 
            // dgvGiangVien
            // 
            dgvGiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiangVien.Columns.AddRange(new DataGridViewColumn[] { txbMatk, txbMagv, txbTengv, txbNgaysinh, Gioi_tinh, txbemail, Txbsdt });
            dgvGiangVien.Location = new Point(14, 397);
            dgvGiangVien.Name = "dgvGiangVien";
            dgvGiangVien.RowHeadersWidth = 51;
            dgvGiangVien.RowTemplate.Height = 29;
            dgvGiangVien.Size = new Size(887, 188);
            dgvGiangVien.TabIndex = 21;
            dgvGiangVien.CurrentCellChanged += dgvGiangVien_CurrentCellChanged;
            // 
            // txbMatk
            // 
            txbMatk.DataPropertyName = "MaTK";
            txbMatk.HeaderText = "Mã TK";
            txbMatk.MinimumWidth = 6;
            txbMatk.Name = "txbMatk";
            // 
            // txbMagv
            // 
            txbMagv.DataPropertyName = "Magv";
            txbMagv.HeaderText = "Mã GV";
            txbMagv.MinimumWidth = 6;
            txbMagv.Name = "txbMagv";
            // 
            // txbTengv
            // 
            txbTengv.DataPropertyName = "Ten";
            txbTengv.HeaderText = "TênGV";
            txbTengv.MinimumWidth = 6;
            txbTengv.Name = "txbTengv";
            // 
            // txbNgaysinh
            // 
            txbNgaysinh.DataPropertyName = "Ngaysinh";
            txbNgaysinh.HeaderText = "Ngày sinh";
            txbNgaysinh.MinimumWidth = 6;
            txbNgaysinh.Name = "txbNgaysinh";
            // 
            // Gioi_tinh
            // 
            Gioi_tinh.DataPropertyName = "Gioi_tinh";
            Gioi_tinh.HeaderText = "Giới tính";
            Gioi_tinh.MinimumWidth = 6;
            Gioi_tinh.Name = "Gioi_tinh";
            // 
            // txbemail
            // 
            txbemail.DataPropertyName = "Email";
            txbemail.HeaderText = "Email";
            txbemail.MinimumWidth = 6;
            txbemail.Name = "txbemail";
            // 
            // Txbsdt
            // 
            Txbsdt.DataPropertyName = "Sdt";
            Txbsdt.HeaderText = "SĐT";
            Txbsdt.MinimumWidth = 6;
            Txbsdt.Name = "Txbsdt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(728, 152);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 22;
            label8.Text = "Giới tính";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Enabled = false;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(674, 178);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(788, 178);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(363, 258);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // Admin2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(914, 611);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(dgvGiangVien);
            Controls.Add(TbxMaGV);
            Controls.Add(TbxEmail);
            Controls.Add(TbxSDT);
            Controls.Add(TbxTenGV);
            Controls.Add(TbxMaTK);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý Thông Tin và Điểm ";
            Load += Admin2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TbxMaTK;
        private TextBox TbxTenGV;
        private TextBox TbxSDT;
        private TextBox TbxEmail;
        private TextBox TbxMaGV;
        private DataGridView dgvGiangVien;
        private DataGridViewTextBoxColumn txbMatk;
        private DataGridViewTextBoxColumn txbMagv;
        private DataGridViewTextBoxColumn txbTengv;
        private DataGridViewTextBoxColumn txbNgaysinh;
        private DataGridViewTextBoxColumn Gioi_tinh;
        private DataGridViewTextBoxColumn txbemail;
        private DataGridViewTextBoxColumn Txbsdt;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
    }
}