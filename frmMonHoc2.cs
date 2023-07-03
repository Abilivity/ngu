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
    public partial class frmMonHoc2 : Form
    {
        string nam = "";
        public frmMonHoc2(string mmh, string ml, string mgv,string nam)
        {
            this.nam = nam;
            this.mmh = mmh;
            this.ml = ml;
            this.mgv = mgv;
            InitializeComponent();
        }
        string mmh;
        string ml;
        string mgv;

        private void frmMonHoc2_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm dữ liệu cho môn học";
                textBox3.Text = mmh;
            }
            else
            {
                this.Text = "Cập nhật dữ liệu môn học";
                textBox1.Text = mgv;
                textBox2.Text = ml;
                textBox3.Text = mmh;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mgv))//nếu thêm mới sinh viên
            {
                sql = "ThemDuLieuForMonHoc";//gọi tới procedure thêm mới sinh viên

            }
            else//nếu cập nhật sinh viên
            {
                 sql = "UpdateLieuForMonHoc";//gọi tới procedure cập nhật sinh viên
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value = textBox2.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = textBox1.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = textBox3.Text
            });
            var rs = new Database().ExeCute(sql, lstPara);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)//nếu thuwcjt hi thành công
            {
                if (string.IsNullOrEmpty(mgv))//nếu thêm mới
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                }
                this.Dispose();//đóng form sau khi thêm mới/cập nhật thành công
            }
            else//nếu không thành công
            {
                MessageBox.Show("Thực thi thất bại");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string sql = "DeleteMH";
            //List<CustomParameter> lstPara = new List<CustomParameter>();
            //lstPara.Add(new CustomParameter()
            //{
            //    key = "@mamonhoc",
            //    value = textBox3.Text
            //});
            //var rs = new Database().ExeCute(sql, lstPara);
            //MessageBox.Show("Xóa thành công");

        }
    }
}
