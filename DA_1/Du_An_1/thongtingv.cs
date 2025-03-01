using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_1
{
    public partial class thongtingv : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);

        public thongtingv()
        {
            InitializeComponent();
        }

        private void thongtingv_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            conn.Open();
            string query = @"SELECT TK.MaTK, TK.Trangthai, GV.Magv, GV.Ten, GV.Ngaysinh, GV.Gioi_tinh, GV.Email, GV.Sdt FROM TK 
                            LEFT JOIN GV ON TK.MaTK = GV.MaTK
                            WHERE TK.Macv = 'CV2'";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dgvGiangVien.DataSource = ds.Tables[0];
            reader.Close();
            conn.Close();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            TbxMaTK.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbMatk"].Value.ToString();
            TbxMaGV.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbMagv"].Value.ToString();
            TbxTenGV.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbTengv"].Value.ToString();
            TbxSDT.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Txbsdt"].Value.ToString();
            TbxEmail.Text = dgvGiangVien.Rows[e.RowIndex].Cells["txbemail"].Value.ToString();
            string a = dgvGiangVien.Rows[e.RowIndex].Cells["txbNgaysinh"].Value.ToString();
            if (a == "")
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                dateTimePicker1.Value = Convert.ToDateTime(dgvGiangVien.Rows[e.RowIndex].Cells["txbNgaysinh"].Value);
            }
            comboBox3.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Trangthai"].Value.ToString();
            string gioitinh = dgvGiangVien.Rows[e.RowIndex].Cells["Gioi_tinh"].Value.ToString();
            if (gioitinh.ToLower() == "nam")
            {
                radioButton1.Checked = true;
            }
            if (gioitinh.ToLower() == "nữ")
            {
                radioButton2.Checked = true;
            }

        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txbtimkiem.Text == "")
            {
                LoadData();
            }
            else
            {
                string query = @$"SELECT TK.MaTK, TK.Trangthai, GV.Magv, GV.Ten, GV.Ngaysinh, GV.Gioi_tinh, GV.Email, GV.Sdt FROM TK 
                                LEFT JOIN GV ON TK.MaTK = GV.MaTK
                                WHERE TK.Macv = 'CV2'
			                    AND TK.MaTK like '%{txbtimkiem.Text}%' 
								OR GV.Magv like '%{txbtimkiem.Text}%' 
                                OR GV.Ten like N'%{txbtimkiem.Text}%'";
                SqlCommand sqlmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = sqlmd.ExecuteReader();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ds.Tables.Add(dt);
                dgvGiangVien.DataSource = ds.Tables[0];
                reader.Close();
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateStudentInput())
                {

                    conn.Open();
                    string querycheckMagv = $"select * from GV where Magv = '{TbxMaGV.Text}'";
                    using (SqlCommand command = new SqlCommand(querycheckMagv, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Mã GV đã tồn tại");
                            }
                            else
                            {
                                reader.Close();

                                string TK = TbxMaTK.Text;
                                string TrangThai = comboBox3.Text;
                                string query = @"INSERT INTO GV (MaTK, Magv, Ten, Sdt, Email, NgaySinh, Gioi_tinh)
                                 VALUES (@MaTK, @Magv, @Ten, @Sdt, @Email, @NgaySinh, @GioiTinh)";
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@MaTK", TbxMaTK.Text);
                                cmd.Parameters.AddWithValue("@Magv", TbxMaGV.Text);
                                cmd.Parameters.AddWithValue("@Ten", TbxTenGV.Text);
                                cmd.Parameters.AddWithValue("@Sdt", TbxSDT.Text);
                                cmd.Parameters.AddWithValue("@Email", TbxEmail.Text);
                                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                                string checkgiotinh = "";
                                if (radioButton1.Checked)
                                {
                                    checkgiotinh = "Nam";
                                }
                                if (radioButton2.Checked)
                                {
                                    checkgiotinh = "Nữ";
                                }
                                cmd.Parameters.AddWithValue("@GioiTinh", checkgiotinh);

                                cmd.ExecuteNonQuery();
                                UpdateStudenttrangthai(TK, TrangThai);
                                conn.Close();
                                clear();
                                LoadData();
                                MessageBox.Show("Thêm mới thành công!");

                            }
                        }
                    }               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateStudentInput())
                {

                    conn.Open();
                    string querycheckMagv = $"select * from GV where Magv = '{TbxMaGV.Text}'";
                    using (SqlCommand command = new SqlCommand(querycheckMagv, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Không tìm thấy Mã GV");
                            }
                            else
                            {
                                reader.Close();

                                string TK = TbxMaTK.Text;
                                string TrangThai = comboBox3.Text;

                                string query = @"UPDATE GV
                                                 SET Ten = @Ten, Sdt = @Sdt, Email = @Email, NgaySinh = @NgaySinh, Gioi_tinh = @GioiTinh
                                                 WHERE  Magv = @Magv";
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@MaTK", TbxMaTK.Text);
                                cmd.Parameters.AddWithValue("@Magv", TbxMaGV.Text);
                                cmd.Parameters.AddWithValue("@Ten", TbxTenGV.Text);
                                cmd.Parameters.AddWithValue("@Sdt", TbxSDT.Text);
                                cmd.Parameters.AddWithValue("@Email", TbxEmail.Text);
                                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                                string checkgiotinh = "";
                                if (radioButton1.Checked)
                                {
                                    checkgiotinh = "Nam";
                                }
                                if (radioButton2.Checked)
                                {
                                    checkgiotinh = "Nữ";
                                }
                                cmd.Parameters.AddWithValue("@GioiTinh", checkgiotinh);
                                cmd.ExecuteNonQuery();
                                UpdateStudenttrangthai(TK, TrangThai);
                                conn.Close();

                                clear();
                                LoadData();
                                MessageBox.Show("Cập nhật thành công!");

                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string querycheckMagv = $"select * from GV where Magv = '{TbxMaGV.Text}'";
                using (SqlCommand command = new SqlCommand(querycheckMagv, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())

                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Không tìm thấy GV");
                        }
                        else
                        {
                            reader.Close();

                            string query = @"DELETE FROM Lopchitiet WHERE malopgv IN (SELECT Magv FROM Lopgv WHERE Magv = @Magv);
                                            DELETE FROM Lopgv WHERE Magv = @Magv;
                                            DELETE FROM GV WHERE Magv = @Magv;";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Magv", TbxMaGV.Text);
                            cmd.ExecuteNonQuery();
                            string TK = TbxMaTK.Text;
                            DeleteStudentchuyentrangthai(TK);
                            conn.Close();
                            LoadData();
                            MessageBox.Show("Xóa thành công!");

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }
        private bool ValidateStudentInput()
        {
            // Kiểm tra các trường thông tin cần thiết
            if (string.IsNullOrWhiteSpace(TbxMaTK.Text) ||
                string.IsNullOrWhiteSpace(TbxTenGV.Text) ||
                string.IsNullOrWhiteSpace(TbxMaGV.Text) ||
                string.IsNullOrWhiteSpace(TbxEmail.Text) ||
                string.IsNullOrWhiteSpace(TbxSDT.Text) ||
                string.IsNullOrWhiteSpace(comboBox3.Text))

            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường thông tin.");
                return false;
            }

            // Kiểm tra định dạng email
            try
            {
                var mail = new System.Net.Mail.MailAddress(TbxEmail.Text);
            }
            catch
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.");
                return false;
            }

            // Kiểm tra định dạng số điện thoại (ví dụ: 10 chữ số)
            if (!System.Text.RegularExpressions.Regex.IsMatch(TbxSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số.");
                return false;
            }
            DateTime minDate = new DateTime(1960, 1, 1); // Ngày nhỏ nhất
            DateTime maxDate = DateTime.Now.AddYears(-20); // Ngày lớn nhất

            if (dateTimePicker1.Value < minDate || dateTimePicker1.Value > maxDate)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Ngày sinh không hợp lệ");
                // Thực hiện các kiểm tra khác nếu cần

                return false;
            }
            return true;
        }
        private void UpdateStudenttrangthai(string TK, string TrangThai)
        {
            string query = @"
            UPDATE TK
            SET Trangthai = @Trangthai
            WHERE MaTK = @MaTK";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaTK", TK);
                cmd.Parameters.AddWithValue("@Trangthai", TrangThai);


                cmd.ExecuteNonQuery();

            }
        }
        private void DeleteStudentchuyentrangthai(string TK)
        {
            string query = @"
            UPDATE TK
            SET Trangthai = N'Không Hoạt Động'
            WHERE MaTK = @MaTK";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaTK", TK);


                cmd.ExecuteNonQuery();
            }
        }
        private void clear()
        {
            TbxMaTK.Text = "";
            TbxTenGV.Text = "";
            TbxMaGV.Text = "";
            TbxEmail.Text = "";
            TbxSDT.Text = "";
        }
    }
}
