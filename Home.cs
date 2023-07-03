using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
       
        private void menuQuanLyHS_Click(object sender, EventArgs e)
        {
            string nam = cbNam.Text;
            this.Hide();
            new QuanLyHoSoHocSinh(nam).ShowDialog();
            this.Show();
        }

        private void menuQuanLyGV_Click(object sender, EventArgs e)
        {
            
            string nam = cbNam.Text;
            this.Hide();
            new frmDSGV(nam).ShowDialog();
            this.Show();
        }

        private void menuQuanLyLH_Click(object sender, EventArgs e)
        {
            

            string nam = cbNam.Text;
            this.Hide();
            new QuanLyLopHoc(nam).ShowDialog();
            this.Show();

        }

        private void menuQuanLyMH_Click(object sender, EventArgs e)
        {
            

            string nam = cbNam.Text;
            this.Hide();
            new QuanLyMonHoc(nam).ShowDialog();
            this.Show();
        }

        private void menuQuanLyD_Click(object sender, EventArgs e)
        {

            string nam = cbNam.Text;
            this.Hide();
            new QuanLyDiem(nam).ShowDialog();
            this.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmREADME().ShowDialog();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
