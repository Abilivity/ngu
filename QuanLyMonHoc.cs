using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyTruongHoc
{
    public partial class QuanLyMonHoc : Form
    {
        string nam = "";
        public QuanLyMonHoc(string nam)
        {
            this.nam = nam;
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private string tukhoa = "";

      

        private void LoadDSMH()
        {
            string sql = "selectAllMonHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dataGridView1.DataSource = new Database().SelectData(sql, lstPara);
        }

      

      

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            //dataGridView1.Columns["mamonhoc"].HeaderText = "Mã MH";
            dataGridView1.Columns["tenmonhoc"].HeaderText = "Tên môn học";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSMH();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmMonHoc(null).ShowDialog();
            LoadDSMH();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dataGridView1.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new frmMonHoc1(mamh,nam).ShowDialog();
                LoadDSMH();
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"D:\KTPMxuatFileExcel\MONHOC\", "danhsachmonhoc");
            MessageBox.Show("Xuất file thành công");
        }
    }
}
