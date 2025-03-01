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

namespace Du_An_1
{
    public partial class Diemsv : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connect);
        private string Tk;
        private string Mk;
        public Diemsv(string tk, string mk)
        {
            InitializeComponent();
            Tk = tk;
            Mk = mk;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Diemsv_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = @$"SELECT 
                                TK.MaTK,
                                SV.Masv,
                                Qldiem.TenSV,
                                Qldiem.Toan,
                                Qldiem.Van,
                                Qldiem.Anh,
                                Qldiem.Su,
                                Qldiem.Dia
                            FROM TK
                            INNER JOIN 
                                SV ON TK.MaTK = SV.MaTK
                            INNER JOIN 
                                Qldiem ON SV.Masv = Qldiem.Masv
                            WHERE 
                                TK.Taikhoan = '{Tk}' AND TK.Matkhau = '{Mk}';";
            SqlCommand sqlmd = new SqlCommand(query, conn);
            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dgvDiemSinhVien.DataSource = ds.Tables[0];
            reader.Close();

        }

        private void dgvDiemSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDiemSinhVien_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaTK.Text = dgvDiemSinhVien.Rows[0].Cells[0].Value.ToString();
                txtMasv.Text = dgvDiemSinhVien.Rows[0].Cells[1].Value.ToString();
                txtTen.Text = dgvDiemSinhVien.Rows[0].Cells[2].Value.ToString();
                txtToan.Text = dgvDiemSinhVien.Rows[0].Cells[3].Value.ToString();
                txtVan.Text = dgvDiemSinhVien.Rows[0].Cells[4].Value.ToString();
                txtAnh.Text = dgvDiemSinhVien.Rows[0].Cells[5].Value.ToString();
                txtSu.Text = dgvDiemSinhVien.Rows[0].Cells[6].Value.ToString();
                txtDia.Text = dgvDiemSinhVien.Rows[0].Cells[7].Value.ToString();
            }
            catch(Exception ex) { }

        }
    }
}
