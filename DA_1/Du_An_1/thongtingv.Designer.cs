namespace Du_An_1
{
    partial class thongtingv
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
            dateTimePicker1 = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            dgvGiangVien = new DataGridView();
            txbMatk = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            txbMagv = new DataGridViewTextBoxColumn();
            txbTengv = new DataGridViewTextBoxColumn();
            txbNgaysinh = new DataGridViewTextBoxColumn();
            Gioi_tinh = new DataGridViewTextBoxColumn();
            txbemail = new DataGridViewTextBoxColumn();
            Txbsdt = new DataGridViewTextBoxColumn();
            TbxMaGV = new TextBox();
            TbxEmail = new TextBox();
            TbxSDT = new TextBox();
            TbxTenGV = new TextBox();
            TbxMaTK = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label9 = new Label();
            txbtimkiem = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            comboBox3 = new ComboBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(357, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(825, 164);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 41;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(689, 164);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 40;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(747, 136);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 39;
            label8.Text = "Giới tính";
            // 
            // dgvGiangVien
            // 
            dgvGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiangVien.Columns.AddRange(new DataGridViewColumn[] { txbMatk, Trangthai, txbMagv, txbTengv, txbNgaysinh, Gioi_tinh, txbemail, Txbsdt });
            dgvGiangVien.Location = new Point(12, 379);
            dgvGiangVien.Name = "dgvGiangVien";
            dgvGiangVien.RowHeadersWidth = 51;
            dgvGiangVien.RowTemplate.Height = 29;
            dgvGiangVien.Size = new Size(1054, 188);
            dgvGiangVien.TabIndex = 38;
            dgvGiangVien.CellClick += dgvGiangVien_CellClick;
            // 
            // txbMatk
            // 
            txbMatk.DataPropertyName = "MaTK";
            txbMatk.HeaderText = "Mã TK";
            txbMatk.MinimumWidth = 6;
            txbMatk.Name = "txbMatk";
            txbMatk.Width = 125;
            // 
            // Trangthai
            // 
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.HeaderText = "Trangthai";
            Trangthai.MinimumWidth = 6;
            Trangthai.Name = "Trangthai";
            Trangthai.Width = 125;
            // 
            // txbMagv
            // 
            txbMagv.DataPropertyName = "Magv";
            txbMagv.HeaderText = "Mã GV";
            txbMagv.MinimumWidth = 6;
            txbMagv.Name = "txbMagv";
            txbMagv.Width = 125;
            // 
            // txbTengv
            // 
            txbTengv.DataPropertyName = "Ten";
            txbTengv.HeaderText = "TênGV";
            txbTengv.MinimumWidth = 6;
            txbTengv.Name = "txbTengv";
            txbTengv.Width = 125;
            // 
            // txbNgaysinh
            // 
            txbNgaysinh.DataPropertyName = "Ngaysinh";
            txbNgaysinh.HeaderText = "Ngày sinh";
            txbNgaysinh.MinimumWidth = 6;
            txbNgaysinh.Name = "txbNgaysinh";
            txbNgaysinh.Width = 125;
            // 
            // Gioi_tinh
            // 
            Gioi_tinh.DataPropertyName = "Gioi_tinh";
            Gioi_tinh.HeaderText = "Giới tính";
            Gioi_tinh.MinimumWidth = 6;
            Gioi_tinh.Name = "Gioi_tinh";
            Gioi_tinh.Width = 125;
            // 
            // txbemail
            // 
            txbemail.DataPropertyName = "Email";
            txbemail.HeaderText = "Email";
            txbemail.MinimumWidth = 6;
            txbemail.Name = "txbemail";
            txbemail.Width = 125;
            // 
            // Txbsdt
            // 
            Txbsdt.DataPropertyName = "Sdt";
            Txbsdt.HeaderText = "SĐT";
            Txbsdt.MinimumWidth = 6;
            Txbsdt.Name = "Txbsdt";
            Txbsdt.Width = 125;
            // 
            // TbxMaGV
            // 
            TbxMaGV.Location = new Point(80, 326);
            TbxMaGV.Name = "TbxMaGV";
            TbxMaGV.Size = new Size(211, 27);
            TbxMaGV.TabIndex = 37;
            // 
            // TbxEmail
            // 
            TbxEmail.Location = new Point(357, 159);
            TbxEmail.Name = "TbxEmail";
            TbxEmail.Size = new Size(211, 27);
            TbxEmail.TabIndex = 36;
            // 
            // TbxSDT
            // 
            TbxSDT.Location = new Point(357, 323);
            TbxSDT.Name = "TbxSDT";
            TbxSDT.Size = new Size(211, 27);
            TbxSDT.TabIndex = 35;
            // 
            // TbxTenGV
            // 
            TbxTenGV.Location = new Point(80, 242);
            TbxTenGV.Name = "TbxTenGV";
            TbxTenGV.Size = new Size(211, 27);
            TbxTenGV.TabIndex = 34;
            // 
            // TbxMaTK
            // 
            TbxMaTK.Location = new Point(80, 159);
            TbxMaTK.Name = "TbxMaTK";
            TbxMaTK.ReadOnly = true;
            TbxMaTK.Size = new Size(211, 27);
            TbxMaTK.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 303);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 32;
            label7.Text = "MãGV";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 216);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 31;
            label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 133);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 300);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 29;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 219);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 28;
            label2.Text = "TênGV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 136);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 27;
            label4.Text = "Mã TK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(357, 37);
            label1.Name = "label1";
            label1.Size = new Size(324, 39);
            label1.TabIndex = 26;
            label1.Text = "Thông Tin Giáo viên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(747, 300);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 43;
            label9.Text = "Tìm kiếm";
            // 
            // txbtimkiem
            // 
            txbtimkiem.Location = new Point(678, 323);
            txbtimkiem.Name = "txbtimkiem";
            txbtimkiem.Size = new Size(211, 27);
            txbtimkiem.TabIndex = 44;
            txbtimkiem.TextChanged += txbtimkiem_TextChanged;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Image = Properties.Resources.kisspng_computer_icons_clip_art_check_mark_x_mark_astrolog_filegartoon_actions_cancel_svg_wikimedia_common_5c53792fbb7cb5_625824561548974383768;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(986, 236);
            btnXoa.Margin = new Padding(2, 3, 2, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 35);
            btnXoa.TabIndex = 142;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Yellow;
            btnSua.Image = Properties.Resources.kisspng_pencil_ico_icon_pencil_icon_png_5aa1fc84aca021_6696863715205653807071;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(986, 185);
            btnSua.Margin = new Padding(2, 3, 2, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 35);
            btnSua.TabIndex = 141;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Image = Properties.Resources.green_add_button_12023;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(986, 129);
            btnThem.Margin = new Padding(2, 3, 2, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 35);
            btnThem.TabIndex = 140;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Hoạt Động", "Không Hoạt Động" });
            comboBox3.Location = new Point(673, 237);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(199, 28);
            comboBox3.TabIndex = 159;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(742, 214);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 158;
            label10.Text = "Trạng thái";
            // 
            // thongtingv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1115, 650);
            Controls.Add(comboBox3);
            Controls.Add(label10);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txbtimkiem);
            Controls.Add(label9);
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
            Name = "thongtingv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý Thông Tin và Điểm ";
            Load += thongtingv_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiangVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label8;
        private DataGridView dgvGiangVien;
        private TextBox TbxMaGV;
        private TextBox TbxEmail;
        private TextBox TbxSDT;
        private TextBox TbxTenGV;
        private TextBox TbxMaTK;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private TextBox txbtimkiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn txbMatk;
        private DataGridViewTextBoxColumn Trangthai;
        private DataGridViewTextBoxColumn txbMagv;
        private DataGridViewTextBoxColumn txbTengv;
        private DataGridViewTextBoxColumn txbNgaysinh;
        private DataGridViewTextBoxColumn Gioi_tinh;
        private DataGridViewTextBoxColumn txbemail;
        private DataGridViewTextBoxColumn Txbsdt;
        private ComboBox comboBox3;
        private Label label10;
    }
}