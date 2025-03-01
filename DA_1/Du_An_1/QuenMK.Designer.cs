namespace Du_An_1
{
    partial class QuenMK
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(257, 30);
            label1.Name = "label1";
            label1.Size = new Size(273, 47);
            label1.TabIndex = 1;
            label1.Text = "Quên Mật Khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Raleway ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 101);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 5;
            label2.Text = "Tài Khoản :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Raleway ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 155);
            label3.Name = "label3";
            label3.Size = new Size(125, 24);
            label3.TabIndex = 7;
            label3.Text = "Mã Tài Khoản:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(201, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 27);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Raleway ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 203);
            label4.Name = "label4";
            label4.Size = new Size(127, 24);
            label4.TabIndex = 9;
            label4.Text = "Mật khẩu mới:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(201, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 27);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Raleway ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 259);
            label5.Name = "label5";
            label5.Size = new Size(167, 24);
            label5.TabIndex = 11;
            label5.Text = "Nhập lại Mật Khẩu:";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(436, 324);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuenMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý Thông Tin và Điểm ";
            FormClosing += QuenMK_FormClosing;
            Load += QuenMK_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
    }
}