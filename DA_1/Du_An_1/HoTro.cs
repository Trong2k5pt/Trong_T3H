using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Du_An_1
{
    public partial class HoTro : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        private string Tk;
        private string Mk;
        public HoTro(string tK, string mk)
        {
            InitializeComponent();
            Tk = tK;
            Mk = mk;
        }

        private void HoTro_Load(object sender, EventArgs e)
        {

            checktk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && comboBox1.Text.Trim() != "" && tb_ch.Text.Trim() != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn thực sự muốn thao tác", "Xác nhận", MessageBoxButtons.YesNo))
                {
                    string subject = "Hỗ Trợ";
                    string body = @$"Ngày gửi:{DateTime.Now}
                                     Mã người hỗ trợ: {textBox1.Text}
                                     Tên người hỗ trợ: {textBox2.Text}
                                     Email người hỗ trợ: {textBox3.Text}
                                     Loại Hỗ trợ: {comboBox1.Text}
                                     Nội Dung hỗ trợ: {tb_ch.Text} ";

                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress("thiendocong18@gmail.com");

                    mail.To.Add("docongthien123@gmail.com");

                    mail.Subject = subject;

                    mail.Body = body;


                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    SmtpServer.Port = 587; // 

                    SmtpServer.Credentials = new NetworkCredential("thiendcph46905@fpt.edu.vn", "aecqifebvorzepsg");

                    SmtpServer.EnableSsl = true; // True nếu máy chủ yêu cầu SSL

                    try

                    {

                        // Gửi email

                        SmtpServer.Send(mail);

                        MessageBox.Show("Gửi thành công");

                    }

                    catch (Exception ex)

                    {

                        MessageBox.Show("Có lỗi xảy ra");

                    }

                }
            }
        }
        private void checktk()
        {
            conn.Open();
            string query2 = $"SELECT * FROM TK WHERE Taikhoan = '{Tk}' and Matkhau = '{Mk}' and Macv = 'CV2'";
            using (SqlCommand cmd = new SqlCommand(query2, conn))
            {
                using (SqlDataReader render2 = cmd.ExecuteReader())
                {
                    if (render2.HasRows)
                    {
                        render2.Close();
                        conn.Close();
                        LoadGV();
                    }
                    else
                    {
                        render2.Close();
                        conn.Close();
                    }
                }
            }
            conn.Open();
            string query3 = $"SELECT * FROM TK WHERE Taikhoan = '{Tk}' and Matkhau = '{Mk}' and Macv = 'CV3'";
            using (SqlCommand cmd3 = new SqlCommand(query3, conn))
            {
                
                using (SqlDataReader render3 = cmd3.ExecuteReader())
                {
                    if (render3.HasRows)
                    {
                        render3.Close();
                        conn.Close();
                        LoadHS();
                    }
                    else
                    {
                        render3.Close();
                        conn.Close();
                    }
                }
            }
        }
        private void LoadHS()
        {
            conn.Open();
            string query = @$"select Masv, Ten,Email from SV
                            join TK on SV.MaTK = TK.MaTK
                            where TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}'";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlDataReader reader4 = cmd.ExecuteReader();

                    while (reader4.Read())
                    {

                        string columnName1 = reader4["Masv"].ToString();
                        textBox1.Text = columnName1;
                        string columnName2 = reader4["Ten"].ToString();
                        textBox2.Text = columnName2;
                        string columnName3 = reader4["Email"].ToString();
                        textBox3.Text = columnName3;
                    }
                    reader4.Close();
                    conn.Close() ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void LoadGV()
        {
            conn.Open();
            string query = @$"select Magv, Ten, Email from gv
                            join TK on GV.MaTK = TK.MaTK
                            where TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}'";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlDataReader reader4 = cmd.ExecuteReader();

                    while (reader4.Read())
                    {

                        string columnName1 = reader4["Magv"].ToString();
                        textBox1.Text = columnName1;
                        string columnName2 = reader4["Ten"].ToString();
                        textBox2.Text = columnName2;
                        string columnName3 = reader4["Email"].ToString();
                        textBox3.Text = columnName3;
                    }
                    reader4.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoTro_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
