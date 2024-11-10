using DANG_NHAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPMUD
{
    public partial class Chuong_trinh : Form
    {
        public Chuong_trinh()
        {
            InitializeComponent();
        }


        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dang_nhap DN = new Dang_nhap();
            DN.Show(); //Check2
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCosokhaonghiem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Chuong_trinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
