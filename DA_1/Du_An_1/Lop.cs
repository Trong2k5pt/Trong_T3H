using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_1
{
    public partial class Lop : Form
    {
        static string connect = @"Data Source=DESKTOP-U541KH8\SQLEXPRESS;Initial Catalog=QLSVDA1;Integrated Security=True;";
        static SqlConnection conn = new SqlConnection(connect);
        public Lop()
        {
            InitializeComponent();
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            Loadloc();
            load();
            loadlop();
            loadgv();
            loadlopcogv();
            datasv();
            datalopgv();
            datalopchitiet();


        }
        private void load()
        {
            string query = $"select * from Lop ";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView1.DataSource = ds.Tables[0];
            reader.Close();
        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string checkmalop = textBox1.Text;
            string query = $"select * from Lop where Malop = '{checkmalop}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Lớp có mã vừa nhập đã tồn tại!");
                    }
                    else
                    {
                        reader.Close();

                        string MaLop = textBox1.Text.Trim();
                        string TenLop = textBox2.Text.Trim();

                        if (MaLop != "" && TenLop != "")
                        {
                            string query1 = "insert into Lop(Malop,Tenlop)" +
                            $"values('{MaLop}', N'{TenLop}')";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();
                            MessageBox.Show("thêm thành công");
                            Lop_Load(sender, e);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Mã Lớp và tên lớp không được để trống.");
                        }
                    }

                }
            }
        }

        private void Lop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string checkmalop = textBox1.Text;
            string query = $@"select * from Lop where Malop = '{checkmalop}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Không tìm thấy mã lớp");
                    }
                    else
                    {
                        reader.Close();

                        string MaLop = textBox1.Text;
                        string TenLop = textBox2.Text;

                        if (MaLop != null && TenLop != null)
                        {
                            string query1 = @$"UPDATE Lop
                                                SET Tenlop = N'{textBox2.Text}'
                                                WHERE Malop = '{textBox1.Text}'";
                            SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                            sqlCommand1.ExecuteNonQuery();
                            Lop_Load(sender, e);
                            Clear();
                            MessageBox.Show("Sửa thành công");

                        }
                        else
                        {
                            MessageBox.Show("Tên ớp không được để trống.");
                        }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string checkmalop = textBox1.Text;
            string query = $@"select * from Lop where Malop = '{checkmalop}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Không tìm thấy mã lớp");
                    }
                    else
                    {
                        reader.Close();

                        string delete = @$"DELETE FROM Lopchitiet
                                WHERE malopgv IN (
                                    SELECT malopgv 
                                    FROM Lopgv 
                                    WHERE Malop = '{textBox1.Text}'
                                );

                                DELETE FROM Lopgv
                                WHERE Malop = '{textBox1.Text}';

                                DELETE FROM Lop
                                WHERE Malop = '{textBox1.Text}';";
                        SqlCommand cmd = new SqlCommand(delete, conn);
                        cmd.ExecuteNonQuery();

                        Lop_Load(sender, e);
                        Clear();
                        MessageBox.Show("Xóa thành công");

                    }

                }
            }

        }
        private void loadlopcogv()
        {
            string query2 = "select * from Lopgv";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader2);
            ds.Tables.Add(dt);
            dataGridView4.DataSource = ds.Tables[0];
            reader2.Close();
        }
        private void loadlop()
        {
            string query2 = @"SELECT l.Malop, l.Tenlop
                            FROM Lop l
                            LEFT JOIN Lopgv lg ON l.Malop = lg.Malop
                            WHERE lg.Malop IS NULL;";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader2);
            ds.Tables.Add(dt);
            dataGridView2.DataSource = ds.Tables[0];
            reader2.Close();
        }
        private void loadgv()
        {
            string query2 = @"SELECT g.Magv, g.Ten
                            FROM GV g
                            LEFT JOIN Lopgv lg ON g.Magv = lg.Magv
                            WHERE lg.Magv IS NULL
                            AND EXISTS (
                                SELECT 1
                                FROM TK t
                                WHERE t.MaTK = g.MaTK
                                AND t.Trangthai = N'Hoạt Động'
                            );";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader2);
            ds.Tables.Add(dt);
            dataGridView3.DataSource = ds.Tables[0];
            reader2.Close();
        }
        private void clearlopgv()
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string MaLopgv = textBox3.Text.Trim();
            string magv = textBox4.Text.Trim();

            if (MaLopgv != "" && magv != "")
            {
                string query1 = "insert into Lopgv(Malop,Magv)" +
                $"values('{MaLopgv}', '{magv}')";
                SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                sqlCommand1.ExecuteNonQuery();

                Lop_Load(sender, e);
                clearlopgv();
                MessageBox.Show("thêm thành công");
            }
            else
            {
                MessageBox.Show("Mã Lớp và mã giáo viên không được để trống.");
            }
        }
        private string malopgv;
        private void button5_Click(object sender, EventArgs e)
        {
            string query = $@"select * from Lopgv where malopgv = '{malopgv}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("xin mời chọn lớp Có giáo viên để sửa");
                    }
                    else
                    {
                        reader.Close();
                        string MaLop = textBox3.Text;
                        string Magv = textBox4.Text;

                        string query1 = @$"UPDATE Lopgv
                                                SET Malop = '{textBox3.Text}',
                                                Magv = '{textBox4.Text}'
                                                WHERE malopgv = '{malopgv}'";
                        SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                        sqlCommand1.ExecuteNonQuery();
                        Lop_Load(sender, e);
                        clearlopgv();
                        MessageBox.Show("Sửa thành công");

                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = $@"select * from Lopgv where malopgv = '{malopgv}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("xin mời chọn lớp Có giáo viên để Xóa");
                    }
                    else
                    {
                        reader.Close();
                        string delete = @$"DELETE FROM Lopchitiet 
                                           WHERE malopgv IN (SELECT malopgv FROM Lopgv);
                                           DELETE FROM Lopgv
                                           WHERE malopgv = '{malopgv}';";
                        SqlCommand cmd = new SqlCommand(delete, conn);
                        cmd.ExecuteNonQuery();
                        Lop_Load(sender, e);
                        clearlopgv();
                        MessageBox.Show("Xóa thành công");

                    }

                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string timkiem = textBox5.Text.Trim();
            tklop(timkiem);
            tkgv(timkiem);
            tklopcogv(timkiem);
        }
        private void tklop(string timkiem)
        {
            string query2 = @$"SELECT l.Malop, l.Tenlop
                            FROM Lop l
                            LEFT JOIN Lopgv lg ON l.Malop = lg.Malop
                            WHERE lg.Malop IS NULL
                            AND l.Malop LIKE '%{timkiem}%'
                            OR l.Tenlop LIKE N'%{timkiem}%';";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader2);
            ds.Tables.Add(dt);
            dataGridView2.DataSource = ds.Tables[0];
            reader2.Close();
        }
        private void tkgv(string timkiem)
        {
            string query2 = @$"SELECT g.Magv, g.Ten
                            FROM GV g
                            LEFT JOIN Lopgv lg ON g.Magv = lg.Magv
                            WHERE lg.Magv IS NULL
                            AND g.Magv LIKE '%{timkiem}%'
                            OR g.Ten LIKE '%{timkiem}%';";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader2);
            ds.Tables.Add(dt);
            dataGridView3.DataSource = ds.Tables[0];
            reader2.Close();
        }
        private void tklopcogv(string timkiem)
        {
            string query2 = @$"SELECT * FROM Lopgv
                               WHERE malopgv like '%{timkiem}%'
                               OR Malop like '%{timkiem}%'
                               OR Magv like '%{timkiem}%'";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader2);
            ds.Tables.Add(dt);
            dataGridView4.DataSource = ds.Tables[0];
            reader2.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex) { }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox4.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                malopgv = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex) { }
        }
        private string malopct;
        private void button9_Click(object sender, EventArgs e)
        {
            string Malopgv = textBox8.Text.Trim();
            string Masv = textBox7.Text.Trim();

            if (Malopgv != "" && Masv != "")
            {
                string query1 = "insert into Lopchitiet(malopgv,Masv)" +
                $"values('{Malopgv}', '{Masv}')";
                SqlCommand sqlCommand1 = new SqlCommand(query1, conn);
                sqlCommand1.ExecuteNonQuery();
                cleards();
                datalopchitiet();
                datalopgv();
                datasv();
                MessageBox.Show("thêm thành công");
            }
            else
            {
                MessageBox.Show("Mã Lớp và mã sinh viên không được để trống.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = $@"select * from lopchitiet where malopchitiet = '{malopct}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("xin mời chọn lớp để sửa");
                    }
                    else
                    {
                        reader.Close();
                        string malopgv = textBox8.Text;
                        string masv = textBox7.Text;

                        string query1 = @$"update lopchitiet
                                                set malopgv = '{malopgv}',
                                                masv = '{masv}'
                                                where malopchitiet = '{malopct}'";
                        SqlCommand sqlcommand1 = new SqlCommand(query1, conn);
                        sqlcommand1.ExecuteNonQuery();

                        cleards();
                        datalopchitiet();
                        datalopgv();
                        datasv();
                        MessageBox.Show("sửa thành công");

                    }

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = $@"select * from Lopchitiet where malopchitiet = '{malopct}'";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("xin mời chọn lớp Có giáo viên để Xóa");
                    }
                    else
                    {
                        reader.Close();
                        string delete = @$"DELETE FROM Lopchitiet 
                                           WHERE malopchitiet = '{malopct}';";
                        SqlCommand cmd = new SqlCommand(delete, conn);
                        cmd.ExecuteNonQuery();

                        cleards();
                        datalopchitiet();
                        datalopgv();
                        datasv();
                        MessageBox.Show("Xóa thành công");

                    }

                }
            }
        }
        private void cleards()
        {
            textBox8.Text = "";
            textBox7.Text = "";
        }
        private void datalopchitiet()
        {
            string query = @$"SELECT 
                                lct.malopchitiet,l.malopgv,g.Magv, lct.Masv
                            FROM Lopchitiet lct
							JOIN 
                                Lopgv l ON lct.malopgv = l.malopgv
							JOIN 
                                GV g ON l.Magv = g.Magv
							JOIN 
                                SV ON lct.Masv = SV.Masv;";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView5.DataSource = ds.Tables[0];
            reader.Close();
        }
        private void datalopgv()
        {
            string query2 = @$"SELECT 
                                l.malopgv, g.Magv
                            FROM Lopgv l
							JOIN 
                                GV g ON l.Magv = g.Magv";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            ds2.Tables.Add(dt2);
            dataGridView7.DataSource = ds2.Tables[0];
            reader2.Close();
        }
        private void datasv()
        {
            string query2 = @"SELECT s.Masv, s.Ten
                            FROM SV s
                            LEFT JOIN Lopchitiet lc ON s.Masv = lc.Masv
                            WHERE lc.Masv IS NULL;";
            SqlCommand sqlmd2 = new SqlCommand(query2, conn);

            SqlDataReader reader2 = sqlmd2.ExecuteReader();
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            ds2.Tables.Add(dt2);
            dataGridView6.DataSource = ds2.Tables[0];
            reader2.Close();
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox8.Text = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox7.Text = dataGridView6.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                malopct = dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox8.Text = dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox7.Text = dataGridView5.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void Loadloc()
        {
            string query = @"SELECT Malop, Tenlop FROM Lop";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "Tenlop";
                    comboBox1.ValueMember = "Malop";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = comboBox1.SelectedValue.ToString();
            string query = @$"	SELECT 
                                lct.malopchitiet,l.malopgv,g.Magv, lct.Masv
                            FROM Lopchitiet lct
							JOIN 
                                Lopgv l ON lct.malopgv = l.malopgv
							JOIN 
								Lop ON l.Malop = Lop.Malop
							JOIN 
                                GV g ON l.Magv = g.Magv
							JOIN 
                                SV ON lct.Masv = SV.Masv
							WHERE 
								l.Malop = '{malop}';";
            SqlCommand sqlmd = new SqlCommand(query, conn);

            SqlDataReader reader = sqlmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ds.Tables.Add(dt);
            dataGridView5.DataSource = ds.Tables[0];
            reader.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            datalopchitiet();
            comboBox1.Text = "";
        }
    }
}
