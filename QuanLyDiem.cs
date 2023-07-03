using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyTruongHoc
{
    public partial class QuanLyDiem : Form
    {
        string nam = "";
        public QuanLyDiem(string nam)

        {
            this.nam = nam;
            InitializeComponent();
        }
        private void LoadDSDiem(string a, string b)
        {
            string sql = "selectAllDiem";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@mon",
                value = a
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@lop",
                value = b
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });

            dataGridView1.DataSource = new Database().SelectData(sql, lstPara);
            int rowCount = dataGridView1.Rows.Count;
            if(rowCount == 0) { MessageBox.Show("Xin mời thêm học sinh vào lớp"); }
            this.Controls.Add(dataGridView1);
            
            for (int i = 0; i < rowCount; i++)
            {

                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDSDiem(txtMon.Text, txtLop.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var diem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                var mhs = dataGridView1.Rows[e.RowIndex].Cells["mahocsinh"].Value.ToString();
                var mmh = txtMon.Text;
                // Cần truyền mã ssinh viên này vào formsinh vien;
                new frmDiem(mhs, mmh, diem,nam).ShowDialog();
                
                LoadDSDiem(txtMon.Text, txtLop.Text);


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

        private void txtLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"D:\KTPMxuatFileExcel\DIEM_LOP_MON\", "danhsachdiem");
            MessageBox.Show("Xuất file thành công");
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            var ml=txtLop.Text;
            var mmh = txtMon.Text;
            new frmDiem1(ml, mmh,nam).ShowDialog();
            LoadDSDiem(txtMon.Text, txtLop.Text);
        }
    }
}
