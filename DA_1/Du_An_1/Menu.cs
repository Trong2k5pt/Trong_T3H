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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.FormClosed += (a, b) => this.Show();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thongtingv ttgv = new thongtingv();
            ttgv.FormClosed += (a, b) => this.Show();
            ttgv.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dangky ttgv = new Dangky();
            ttgv.FormClosed += (a, b) => this.Show();
            ttgv.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.FormClosed += (a, b) => this.Show();
            l.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Đăng xuất", "Xác Nhận Thoát", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
