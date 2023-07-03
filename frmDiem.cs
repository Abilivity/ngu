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
    public partial class frmDiem : Form
    {
        string nam = "";
        public frmDiem(string mhs,string mmh,string diem,string nam)
        {
            this.nam = nam;
            this.mhs = mhs;
            this.mmh = mmh;
            this.diem = diem;
            InitializeComponent();
        }
        private string mmh;
        private string mhs;
        private string diem;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string sql = "";
        List<CustomParameter> lstPara = new List<CustomParameter>();
        private void frmDiem_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mmh))
            {
                this.Text = "Thêm mới điểm";
            }
            else
            {
                this.Text = "Cập nhật điểm";
                sql = "selectDiem";
                lstPara.Add(new CustomParameter()
                {
                    key = "@mahocsinh",
                    value = mhs
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mmh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nam",
                    value = nam
                });




                txtDiem.Text = diem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            
                sql = "updateDiem";

            lstPara.Add(new CustomParameter()
            {
                key = "@diem",
                value = txtDiem.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@mahocsinh",
                value = mhs
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = mmh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });
            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(diem))
                {
                    MessageBox.Show("Thêm mới điểm thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật mới điểm thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }


        }
    }
}
