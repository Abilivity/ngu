using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace QuanLyTruongHoc
{
    public partial class QuanLyHoSoHocSinh : Form
    {
        string nam = "";
        public QuanLyHoSoHocSinh(string nam)
        {
            this.nam = nam;
            InitializeComponent();
        }
        private string tukhoa = "";

        private void QuanLyHoSoHocSinh_Load_1(object sender, EventArgs e)
        {
            LoadDSSV();
        }
        private void LoadDSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllHocSinh", lstPara);
            
            int rowCount = dgvSinhVien.Rows.Count;
            this.Controls.Add(dgvSinhVien);
            textBox1.Text = rowCount.ToString();
            for (int i = 0; i<rowCount; i++)
            {

                dgvSinhVien.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void dgvSinhVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // hiện form cập nhật sinh viên, lấy mã sinh viên mới cập nhật được
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                // Cần truyền mã ssinh viên này vào formsinh vien;
                new frmHocSinh(msv,nam).ShowDialog();
                LoadDSSV(); 
            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {   
            new frmHocSinh(null,nam).ShowDialog();// thêm mới thì mã sinh viên = null
            LoadDSSV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSSV();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_DoubleClick(object sender, EventArgs e)
        {

        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            export2Excel(dgvSinhVien, @"D:\KTPMxuatFileExcel\HOCSINH\", "danhsachhocsinh");
            MessageBox.Show("Xuất file thành công");
            
        }

        private void QuanLyHoSoHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
       
    
        
        }
    }