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
    public partial class frmThemLop : Form
    {
        public frmThemLop()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "ThemLop";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value =textBox1.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tenlop",
                value = textBox2.Text
            });
            var rs = new Database().ExeCute(sql, lstPara);
            MessageBox.Show("Thêm lớp thành công");
            this.Close();

        }
    }
}
