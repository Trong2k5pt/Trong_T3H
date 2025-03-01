using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Du_An_1
{
    public partial class QuenMK : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        public QuenMK()
        {
            InitializeComponent();
        }
        private void QuenMK_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == textBox4.Text)
            {
                string query = $"SELECT * FROM TK WHERE Taikhoan = '{textBox1.Text}' and MaTK = '{textBox2.Text}'";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Close();
                            string query1 = "update TK " +
                            $"set Matkhau = '{textBox4.Text}' " +
                            $"where MaTK = '{textBox2.Text}' " +
                            $"and Taikhoan = '{textBox1.Text}'";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();
                            MessageBox.Show("Đổi thành công");
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc Mã Tài khoản sai");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp");
            }
        }

        private void QuenMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
