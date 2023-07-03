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
    public partial class frmDSGV : Form
    {
        public frmDSGV(string nam)
        {
            this.nam = nam;
            InitializeComponent();
        }
        string nam = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string tukhoa = "";
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSGV();
        }
        private void loadDSGV()
        {
            string sql = "SelectAllGiaoVien";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
            int rowCount = dgvDSGV.Rows.Count;
            this.Controls.Add(dgvDSGV);
            textBox2.Text=rowCount.ToString();
            for (int i = 0; i < rowCount; i++)
            {

                dgvDSGV.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmGiaoVien(null,nam).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                new frmGiaoVien(mgv,nam).ShowDialog();
                loadDSGV();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            export2Excel(dgvDSGV, @"D:\KTPMxuatFileExcel\GIAOVIEN\", "danhsachgiaovien");
            MessageBox.Show("Xuất file thành công");
        }
    }
}
