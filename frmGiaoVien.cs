using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien(string mgv,string nam)
        {
            this.nam = nam;
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        string nam;
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new Database().Select("selectgv '" + int.Parse(mgv) + "'");
                txtMaGiaoVien.Text = mgv.ToString();
                txtTen.Text = r["ten"].ToString();
                txtTenDem.Text = r["tendem"].ToString();
                txtHo.Text = r["ho"].ToString();
                if (r["gioitinh"].ToString() == "2")
                {
                    txtGioiTinh.Text = "Nam";
                }
                else
                {
                    txtGioiTinh.Text = "Nữ";
                }

                txtNgaySinh.Text = r["ngaysinh"].ToString();
                txtDienThoai.Text = r["sodienthoai"].ToString();
                
                txtDiaChi.Text = r["diachi"].ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql = "";
            string magiaovien = txtMaGiaoVien.Text;
            string gioitinh;
            if (txtGioiTinh.Text == "Nam")
            {
                gioitinh = "2";
            }
            else
            {
                gioitinh = "1";
            }
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                txtNgaySinh.Select();//trỏ chuột về mtbNgaysinh
                return;//không thực hiện các câu lệnh phía dưới
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "ThemMoiGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = magiaovien
                });
            }
            else
            {
                sql = "updateGV";
                
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = txtHo.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = txtTenDem.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = txtTen.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });

         

            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = txtDienThoai.Text
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = txtDiaChi.Text
            });


            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {

                if (string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật mới giáo viên thành công");
                }
                this.Dispose();
                List<CustomParameter> lstPara1 = new List<CustomParameter>();
                var sql1 = "ThemMoiGV1";
                lstPara1.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = magiaovien
                });
                lstPara1.Add(new CustomParameter()
                {
                    key = "@nam",
                    value = nam
                });
                var rs1 = new Database().ExeCute(sql1, lstPara1);
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
          
        
          

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DeleteGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = txtMaGiaoVien.Text
            });
            var rs = new Database().ExeCute(sql, lstPara);

            MessageBox.Show("Xóa giáo viên thành công");

            this.Dispose();

        }
    }
}
