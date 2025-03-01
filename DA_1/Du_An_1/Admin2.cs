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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_1
{
    public partial class Admin2 : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        private string Tk;
        private string Mk;
        public Admin2(string tK, string mk)
        {
            InitializeComponent();
            Tk = tK;
            Mk = mk;
        }


        private void Admin2_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = @$"SELECT 
                                g.Magv, g.Ten, g.Ngaysinh, g.Gioi_tinh, g.Email, g.Sdt , t.MaTK
                            FROM GV g
                            JOIN 
                                TK t ON g.MaTK = t.MaTK
                            WHERE 
                                t.Taikhoan = '{Tk}' AND t.Matkhau = '{Mk}';";
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


        private void dgvGiangVien_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                TbxTenGV.Text = dgvGiangVien.Rows[0].Cells["txbTengv"].Value.ToString();
                TbxMaTK.Text = dgvGiangVien.Rows[0].Cells["txbMatk"].Value.ToString();
                TbxSDT.Text = dgvGiangVien.Rows[0].Cells["Txbsdt"].Value.ToString();
                TbxEmail.Text = dgvGiangVien.Rows[0].Cells["txbemail"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgvGiangVien.Rows[0].Cells["txbNgaysinh"].Value);
                TbxMaGV.Text = dgvGiangVien.Rows[0].Cells["txbMagv"].Value.ToString();
                string gioitinh = dgvGiangVien.Rows[0].Cells["Gioi_tinh"].Value.ToString();
                if (gioitinh.ToLower() == "nam")
                {
                    radioButton1.Checked = true;
                }
                if (gioitinh.ToLower() == "nữ")
                {
                    radioButton2.Checked = true;
                }
            }
            catch(Exception ex) { }

        }
    }
}
