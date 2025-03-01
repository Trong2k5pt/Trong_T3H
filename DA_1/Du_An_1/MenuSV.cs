using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_An_1
{
    public partial class MenuSV : Form
    {
        private string Tk;
        private string Mk;
        public MenuSV(string Tk, string Mk)
        {
            InitializeComponent();
            this.Tk = Tk;
            this.Mk = Mk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thongtinsv ttsv = new Thongtinsv(Tk, Mk);
            ttsv.FormClosed += (a, b) => this.Show();
            ttsv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Diemsv diemsv = new Diemsv(Tk, Mk);
            diemsv.FormClosed += (a, b) => this.Show();
            diemsv.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HoTro ht = new HoTro(Tk, Mk);
            ht.FormClosed += (a, b) => this.Show();
            ht.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuSV_Load(object sender, EventArgs e)
        {

        }

        private void MenuSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Đăng xuất", "Xác Nhận Thoát", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
