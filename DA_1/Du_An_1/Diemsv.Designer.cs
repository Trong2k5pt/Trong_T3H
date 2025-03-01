namespace Du_An_1
{
    partial class Diemsv
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
            dgvDiemSinhVien = new DataGridView();
            txtAnh = new TextBox();
            txtVan = new TextBox();
            txtToan = new TextBox();
            txtTen = new TextBox();
            txtMasv = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtDia = new TextBox();
            txtSu = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtMaTK = new TextBox();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDiemSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvDiemSinhVien
            // 
            dgvDiemSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiemSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemSinhVien.Location = new Point(20, 359);
            dgvDiemSinhVien.Name = "dgvDiemSinhVien";
            dgvDiemSinhVien.RowHeadersWidth = 51;
            dgvDiemSinhVien.RowTemplate.Height = 29;
            dgvDiemSinhVien.Size = new Size(887, 188);
            dgvDiemSinhVien.TabIndex = 49;
            dgvDiemSinhVien.CurrentCellChanged += dgvDiemSinhVien_CurrentCellChanged;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(377, 319);
            txtAnh.Name = "txtAnh";
            txtAnh.ReadOnly = true;
            txtAnh.Size = new Size(236, 27);
            txtAnh.TabIndex = 48;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(377, 231);
            txtVan.Name = "txtVan";
            txtVan.ReadOnly = true;
            txtVan.Size = new Size(236, 27);
            txtVan.TabIndex = 47;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(377, 137);
            txtToan.Name = "txtToan";
            txtToan.ReadOnly = true;
            txtToan.Size = new Size(236, 27);
            txtToan.TabIndex = 46;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(50, 319);
            txtTen.Name = "txtTen";
            txtTen.ReadOnly = true;
            txtTen.Size = new Size(244, 27);
            txtTen.TabIndex = 45;
            // 
            // txtMasv
            // 
            txtMasv.Location = new Point(50, 231);
            txtMasv.Name = "txtMasv";
            txtMasv.ReadOnly = true;
            txtMasv.Size = new Size(244, 27);
            txtMasv.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 297);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 42;
            label7.Text = "Điểm Anh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 209);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 41;
            label6.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 114);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 40;
            label5.Text = "Điểm Toán ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 297);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 39;
            label3.Text = "Tên HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 209);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 38;
            label2.Text = "Mã HS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 114);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 37;
            label4.Text = "Mã Tài Khoản";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(241, 18);
            label1.Name = "label1";
            label1.Size = new Size(432, 47);
            label1.TabIndex = 36;
            label1.Text = "Thông Tin Điểm Học Sinh";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(684, 231);
            txtDia.Name = "txtDia";
            txtDia.ReadOnly = true;
            txtDia.Size = new Size(236, 27);
            txtDia.TabIndex = 53;
            // 
            // txtSu
            // 
            txtSu.Location = new Point(684, 137);
            txtSu.Name = "txtSu";
            txtSu.ReadOnly = true;
            txtSu.Size = new Size(236, 27);
            txtSu.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(769, 209);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 51;
            label8.Text = "Điểm Địa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(781, 114);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 50;
            label9.Text = "Điểm Sử";
            // 
            // txtMaTK
            // 
            txtMaTK.Location = new Point(50, 143);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.ReadOnly = true;
            txtMaTK.Size = new Size(244, 27);
            txtMaTK.TabIndex = 54;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(769, 308);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 55;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Diemsv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(936, 555);
            Controls.Add(btnThoat);
            Controls.Add(txtMaTK);
            Controls.Add(txtDia);
            Controls.Add(txtSu);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dgvDiemSinhVien);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtTen);
            Controls.Add(txtMasv);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Diemsv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý Thông Tin và Điểm ";
            Load += Diemsv_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiemSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDiemSinhVien;
        private TextBox txtAnh;
        private TextBox txtVan;
        private TextBox txtToan;
        private TextBox txtTen;
        private TextBox txtMasv;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private TextBox txtDia;
        private TextBox txtSu;
        private Label label8;
        private Label label9;
        private TextBox txtMaTK;
        private Button btnThoat;
    }
}