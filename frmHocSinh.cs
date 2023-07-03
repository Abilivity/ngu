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
using System.Data.SqlClient;
namespace QuanLyTruongHoc
{
    public partial class frmHocSinh : Form
    {
        string nam = "";
        public frmHocSinh(string msv,string nam)
        {
            this.nam = nam;
            this.msv = msv;// truyền mã sinh viên
            InitializeComponent();
        }
        private string msv;
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới học sinh";

            }
            else
            {
                this.Text = "Cập nhật thông tin học sinh";
                // lấy thong tin chi tiết của mọt sinh viên dựa vào msv
                //msv là mã sv đc truyền nhờ nút ấn

                var r = new Database().Select("SelectHS'" + msv + "'");
                txtMaHocSinh.Text = r["mahocsinh"].ToString();
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                txtNgaySinh.Text = r["ngaysinh"].ToString();

                if (r["gioitinh"].ToString() == "2")
                {
                    txtGioiTinh.Text = "Nam";
                }
                else
                {
                    txtGioiTinh.Text = "Nữ";
                }
                txtQueQuan.Text = r["diachi"].ToString();
                txtNienKhoa.Text = r["nienkhoa"].ToString();
                txtDienThoai.Text = r["sodienthoai"].ToString();
                txtPhuHuynh.Text = r["phuhuynh"].ToString();
                txtNgayNhapHoc.Text = r["ngaynhaphoc"].ToString();
            }
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //button btnLuu sẽ xử lý 1 trong 2 tình huống
            //trường hợp 1: nếu mã sinh viên không có giá trị -> thêm mới sinh viên
            //trường hợp 2: nếu mã sinh viên có giá trị -> cập nhật thông tin sinh viên

            /*ý tưởng
                -- cho dù thêm mới hay cập nhật
                -- thì đều cần các giá trị như: họ, tên đệm, tên, ngày sinh, giới tính
                    quê quán, địa chỉ, điện thoại, email => các giá trị này dùng cho cả 2 trường hợp
                -- riêng cập nhật sinh viên, cần quan tâm tới mã sinh viên        
            */

            string sql = "";
            string mahocsinh=txtMaHocSinh.Text;
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
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
            //vì ngày sinh ở masketbox, chúng ta set theo dạng dd/mm/yyy
            //nhưng trong csdl lại lưu dưới dạng yyyy-mm-dd
            //=> chúng ta cần chuyển từ dd/mm/yyyy sang yyyy-mm-dd


            string gioitinh ;
            if (txtGioiTinh.Text == "Nam")
            {
                gioitinh = "2";
            }
            else
            {
                gioitinh = "1";
            }//đây là toán tử 2 ngôi
            //nếu radiobutton Nam đc check thì chọn giá trị 1
            //ngược lại chọn giá trị 0 -> phù hợp với giá trị đã được lưu ở csdl

            string nienkhoa = txtNienKhoa.Text;
            string diachi = txtQueQuan.Text;
            string dienthoai = txtDienThoai.Text;
            string phuhuynh = txtPhuHuynh.Text;
            string ngaynhaphoc = txtNgayNhapHoc.Text;

            //khai báo một danh sách tham sô = class CustomParameter -> đã được khai báo ở part 3
            List<CustomParameter> lstPara = new List<CustomParameter>();

            lstPara.Add(new CustomParameter()
            {
                key = "@Ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TenDem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NienKHoa",
                value = nienkhoa
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@SoDienThoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@PhuHuynh",
                value = phuhuynh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgayNhapHoc",
                value = ngaynhaphoc
            });
            if (string.IsNullOrEmpty(msv))//nếu thêm mới sinh viên
            {
                sql = "ThemMoiHS";//gọi tới procedure thêm mới sinh viên
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaHocSinh",
                    value = mahocsinh
                });
                var sql1 = "ThemMoiHS1";
                List<CustomParameter> lstPara1 = new List<CustomParameter>();
                lstPara1.Add(new CustomParameter()
                {
                    key = "@mahocsinh",
                    value = mahocsinh
                });
                lstPara1.Add(new CustomParameter()
                {
                    key = "@nam",
                    value = nam
                });


                var rs = new Database().ExeCute(sql, lstPara);
                var rs1 = new Database().ExeCute(sql1, lstPara1);
                if (rs == 1 && rs1==1)//nếu thuwcjt hi thành công
                {
                    if (string.IsNullOrEmpty(msv))//nếu thêm mới
                    {
                        MessageBox.Show("Thêm mới học sinh thành công");
                    }
                    else//nếu cập nhật
                    {
                        MessageBox.Show("Cập nhật thông tin học sinh thành công");
                    }
                    this.Dispose();//đóng form sau khi thêm mới/cập nhật thành công
                }
                else//nếu không thành công
                {
                    MessageBox.Show("Thực thi thất bại");
                }

            }
            else//nếu cập nhật sinh viên
            {
                sql = "updateHS";//gọi tới procedure cập nhật sinh viên
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaHocSinh",
                    value = msv
                });
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)//nếu thuwcjt hi thành công
                {
                    if (string.IsNullOrEmpty(msv))//nếu thêm mới
                    {
                        MessageBox.Show("Thêm mới học sinh thành công");
                    }
                    else//nếu cập nhật
                    {
                        MessageBox.Show("Cập nhật thông tin học sinh thành công");
                    }
                    this.Dispose();//đóng form sau khi thêm mới/cập nhật thành công
                }
                else//nếu không thành công
                {
                    MessageBox.Show("Thực thi thất bại");
                }
            }



           //truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            //if (rs == 1)//nếu thuwcjt hi thành công
            //{
            //    if (string.IsNullOrEmpty(msv))//nếu thêm mới
            //    {
            //        MessageBox.Show("Thêm mới học sinh thành công");
            //    }
            //    else//nếu cập nhật
            //    {
            //        MessageBox.Show("Cập nhật thông tin học sinh thành công");
            //    }
            //    this.Dispose();//đóng form sau khi thêm mới/cập nhật thành công
            //}
            //else//nếu không thành công
            //{
            //    MessageBox.Show("Thực thi thất bại");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        List<CustomParameter> lstPara = new List<CustomParameter>();
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DeleteHS";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@mahocsinh",
                value = txtMaHocSinh.Text
            });
            var rs = new Database().ExeCute(sql, lstPara);
            
            MessageBox.Show("Xóa học sinh thành công");
                
            this.Dispose();

        }


    }
    
}
