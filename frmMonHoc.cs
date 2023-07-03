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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        public frmMonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }

        private string mamh;
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new Database().Select("selectmh '" + mamh + "'");
                txtTenMH.Text = r["tenmonhoc"].ToString();
                txtMMH.Text = r["mamonhoc"].ToString();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMH.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                txtTenMH.Select();
                return;
            }



            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamh))
            {
                sql = "insertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = txtMMH.Text
                });
            }
            else
            {
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mamh
                });
                sql = "updateMH";
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = txtTenMH.Text
            });


            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin môn học thành công");
                }

                this.Dispose();

            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //string sql = "";
            //List<CustomParameter> lstPara = new List<CustomParameter>();
            
            //sql = "deleteMH";
            //lstPara.Add(new CustomParameter()
            //{
            //    key = "@mamonhoc",
            //    value = txtMMH.Text
            //});
            
            //var rs = new Database().ExeCute(sql, lstPara);

            //MessageBox.Show("Xóa môn học thành công");

            //this.Dispose();

        }
    }
    
}
