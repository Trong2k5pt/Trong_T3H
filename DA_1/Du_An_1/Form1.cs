using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Du_An_1
{
    public partial class Form1 : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connect);
        public Form1()
        {
            InitializeComponent();
        }
        private string Tk = "";
        private string Mk = "";


        private void Form1_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed) 
            {
                conn.Open();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string username = textBox1.Text;
            string password = textBox2.Text;
            Tk = username;
            Mk = password;
            string query = $"SELECT * FROM TK WHERE Taikhoan = '{username}' and Matkhau = '{password}' and Trangthai = N'Hoạt Động'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query2 = $"SELECT * FROM TK WHERE Taikhoan = '{username}' and Matkhau = '{password}' and Macv = 'CV2'";
                        using (SqlCommand cmd = new SqlCommand(query2, conn))
                        {
                            using (SqlDataReader render2 = cmd.ExecuteReader())
                            {
                                if (render2.HasRows)
                                {
                                    render2.Close();
                                    if (conn.State == ConnectionState.Open)
                                    {
                                        conn.Close();
                                    }
                                    MessageBox.Show("Đăng nhập thành công!");
                                    MenuGV mngv = new MenuGV(Tk,Mk);
                                    mngv.FormClosed += (a, b) => this.Show();
                                    mngv.Show();
                                    this.Hide();
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                }
                            }
                        }
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query3 = $"SELECT * FROM TK WHERE Taikhoan = '{username}' and Matkhau = '{password}' and Macv = 'CV1'";
                        using (SqlCommand cmd3 = new SqlCommand(query3, conn))
                        {
                            using (SqlDataReader render3 = cmd3.ExecuteReader())
                            {
                                if (render3.HasRows)
                                {
                                    render3.Close();
                                    if (conn.State == ConnectionState.Open)
                                    {
                                        conn.Close();
                                    }
                                    MessageBox.Show("Đăng nhập thành công!");
                                    Menu mn = new Menu();
                                    mn.FormClosed += (a, b) => this.Show();
                                    mn.Show();
                                    this.Hide();
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                }
                            }
                        }
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query4 = $"SELECT * FROM TK WHERE Taikhoan = '{username}' and Matkhau = '{password}' and Macv = 'CV3'";
                        using (SqlCommand cmd4 = new SqlCommand(query4, conn))
                        {
                            using (SqlDataReader render4 = cmd4.ExecuteReader())
                            {
                                if (render4.HasRows)
                                {
                                    render4.Close();
                                    if (conn.State == ConnectionState.Open)
                                    {
                                        conn.Close();
                                    }
                                    MessageBox.Show("Đăng nhập thành công!");
                                    MenuSV mnsv = new MenuSV(Tk,Mk);
                                    mnsv.FormClosed += (a, b) => this.Show();
                                    mnsv.Show();
                                    this.Hide();
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                }
                            }
                        }
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác hoặc tài khoản không hoạt động!");
                    }
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuenMK quenmk = new QuenMK();
            quenmk.FormClosed += (a, b) => this.Show();
            quenmk.Show();
            this.Hide();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát không", "Xác Nhận Thoát", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                e.Cancel = true;
            }
        }
    }
}
