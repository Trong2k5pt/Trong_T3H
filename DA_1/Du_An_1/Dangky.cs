using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Du_An_1
{
    public partial class Dangky : Form
    {
        private static string connectionString = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);

        public Dangky()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text;
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string macv = comboBoxChucVu.SelectedValue.ToString(); // Assuming a dropdown for roles
            string trangThai = string.IsNullOrWhiteSpace(comboBoxTrangThai.Text) ? "Không hoạt động" : comboBoxTrangThai.Text; // Default status

            if (ValidateInput(maTK, taiKhoan, matKhau, macv))
            {
                RegisterUser(maTK, taiKhoan, matKhau, macv, trangThai);
                loadtk();
            }
        }

        private bool ValidateInput(string maTK, string taiKhoan, string matKhau, string macv)
        {
            if (string.IsNullOrWhiteSpace(maTK) || string.IsNullOrWhiteSpace(taiKhoan) ||
                string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(macv))
            {
                MessageBox.Show("Không được để trống.");
                return false;
            }

            if (taiKhoan.Length < 6)
            {
                MessageBox.Show("Tài khoản phải trên 6 ký tự.");
                return false;
            }

            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải dài trên 6 ký tự.");
                return false;
            }

            if (IsUsernameTaken(taiKhoan))
            {
                MessageBox.Show("Tên tài khoản đã được sử dụng.");
                return false;
            }

            return true;
        }

        private bool IsUsernameTaken(string taiKhoan)
        {
            string query = "SELECT COUNT(*) FROM TK WHERE Taikhoan = @Taikhoan";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Taikhoan", taiKhoan);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return true; 
            }
            finally
            {
                connection.Close();
            }
        }

        private void RegisterUser(string maTK, string taiKhoan, string matKhau, string macv, string trangThai)
        {
            string query = @"INSERT INTO TK (MaTK, Taikhoan, Matkhau, Macv, Trangthai)
                             VALUES (@MaTK, @Taikhoan, @Matkhau, @Macv, @Trangthai)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaTK", maTK);
                    cmd.Parameters.AddWithValue("@Taikhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@Matkhau", matKhau);
                    cmd.Parameters.AddWithValue("@Macv", macv);
                    cmd.Parameters.AddWithValue("@Trangthai", trangThai);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            loadtk();

        }

        private void LoadChucVu()
        {
            string query = "SELECT Macv, Chucvu FROM Chucvu";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxChucVu.DataSource = dt;
                    comboBoxChucVu.DisplayMember = "Chucvu";
                    comboBoxChucVu.ValueMember = "Macv";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void loadtk()
        {

            string query = "SELECT MaTK, Taikhoan, Matkhau, Macv, Trangthai FROM TK";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}
