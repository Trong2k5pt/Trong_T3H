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
    public partial class Thongtinsv : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connect);
        private string Tk;
        private string Mk;
        public Thongtinsv(string tK, string mk)
        {
            InitializeComponent();
            Tk = tK;
            Mk = mk;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Thongtinsv_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = @$"SELECT 
                                SV.Masv, Sv.Ten, SV.Email,SV.Sdt,sv.Que_quan,ngay_sinh
                            FROM TK
                            INNER JOIN 
                                SV ON TK.MaTK = SV.MaTK
                            WHERE 
                               TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}';";
            SqlCommand sqlmd = new SqlCommand(query, conn);
            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dgvTTSinhVien.DataSource = ds.Tables[0];
            reader.Close();
            danhsachlop();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTTSinhVien_CurrentCellChanged(object sender, EventArgs e)
        {
            txtEmail.Text = dgvTTSinhVien.Rows[0].Cells[2].Value.ToString();
            txtMasv.Text = dgvTTSinhVien.Rows[0].Cells[0].Value.ToString();
            txtTen.Text = dgvTTSinhVien.Rows[0].Cells[1].Value.ToString();
            txtSDT.Text = dgvTTSinhVien.Rows[0].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvTTSinhVien.Rows[0].Cells[5].Value);
            txtDiaChi.Text = dgvTTSinhVien.Rows[0].Cells[4].Value.ToString();

        }

        private void danhsachlop()
        {
            string query = @$"	select Lop.Tenlop, GV.Magv, GV.Ten TenGV, SV.Masv, SV.Ten TenSV From Lopchitiet 
                            join Lopgv on Lopchitiet.malopgv = Lopgv.malopgv
                            join SV on Lopchitiet.Masv = SV.Masv
                            join Lop on Lopgv.Malop = Lop.Malop
                            join GV on Lopgv.Magv = GV.Magv
                            join TK on SV.MaTK = TK.MaTK
                            where GV.Magv IN (	select GV.Magv From Lopchitiet 
                            join Lopgv on Lopchitiet.malopgv = Lopgv.malopgv
                            join SV on Lopchitiet.Masv = SV.Masv
                            join Lop on Lopgv.Malop = Lop.Malop
                            join GV on Lopgv.Magv = GV.Magv
                            join TK on SV.MaTK = TK.MaTK
                            where TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}') ";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView1.DataSource = ds.Tables[0];
            reader.Close();
        }
    }
}
