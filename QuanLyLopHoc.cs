using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using app = Microsoft.Office.Interop.Excel.Application;
namespace QuanLyTruongHoc
{
    public partial class QuanLyLopHoc : Form
    {
        string nam="";
        public QuanLyLopHoc(string nam)
        {
            this.nam=nam;
            InitializeComponent();
        }
        private void LoadDSLop1(string a)
        {
            string sql = "SelectLopHoc1";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value = a
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });

            dgvLopHoc1.DataSource = new Database().SelectData(sql, lstPara);
            int rowCount1 = dgvLopHoc1.Rows.Count;
            this.Controls.Add(dgvLopHoc1);
            textBox3.Text = rowCount1.ToString();
            for (int i = 0; i < rowCount1 ; i++)
            {

                dgvLopHoc1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            
        }
        private void LoadDSLop2(string a)
        {
            string sql = "SelectLopHoc2";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value = a
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });

            dgvLopHoc2.DataSource = new Database().SelectData(sql, lstPara);
            int rowCount2 = dgvLopHoc2.Rows.Count;
            this.Controls.Add(dgvLopHoc2);
            textBox4.Text = rowCount2.ToString();

            for (int i = 0; i < rowCount2 ; i++)
            {

                dgvLopHoc2.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            var r = new Database().Select("SelectGiaoVienChuNgiem'" + comboBox1.Text + "','"+ nam +"'");

          
            textBox1.Text = r["hovaten"].ToString();
            textBox2.Text = r["magiaovien"].ToString();
            LoadDSLop1(comboBox1.Text);


            LoadDSLop2(comboBox1.Text);




        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string sql1 = "deleteGiaoVienChuNgiem";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value = comboBox1.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = textBox2.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });
            var rs1 = new Database().ExeCute(sql1, lstPara);
            MessageBox.Show("Xóa thành công");
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Xin mời thêm mới giáo viên chủ nhiệm");




            //var rs = new Database().ExeCute(sql, lstPara);



            //var r = new Database().Select("SelectGiaoVienChuNgiem'" + comboBox1.Text + "'");
            //textBox1.Text = r["hovaten"].ToString();
            //textBox2.Text = r["magiaovien"].ToString();
        }

        private void dgvLopHoc1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mhs = dgvLopHoc1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sql = "deleteHocSinhFromLopHoc";

                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@malop",
                    value = comboBox1.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@mahocsinh",
                    value = mhs
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nam",
                    value = nam
                });
                var rs = new Database().ExeCute(sql, lstPara);

                LoadDSLop1(comboBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
              
                var mlh = comboBox1.Text;
                new frmThemHSVaoLop(mlh,nam).ShowDialog();
                LoadDSLop1(mlh);
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "DeleteLop";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value = comboBox1.Text
            });
            var rs = new Database().ExeCute(sql, lstPara);

            MessageBox.Show("Xóa lớp thành công");

            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mlh = comboBox1.Text;
            new frmThemGVVaoLop(mlh,nam).ShowDialog();
            LoadDSLop2(mlh);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLopHoc2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvLopHoc2.Rows[e.RowIndex].Cells[1].Value.ToString();
                var mmh= dgvLopHoc2.Rows[e.RowIndex].Cells[5].Value.ToString();
                string sql = "deletGiaoVienFromLopHoc";
               
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@malop",
                    value = comboBox1.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
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

                LoadDSLop2(comboBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGiaoVienMoi.Text))
            {
                MessageBox.Show("Xin mời nhập MSGV cần thêm mới");
            }
            else
            {
                string sql = "UpdateGiaoVienChuNgiem";

                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@malop",
                    value = comboBox1.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = txtMaGiaoVienMoi.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nam",
                    value = nam
                });
                var rs1 = new Database().ExeCute(sql, lstPara);
                var r = new Database().Select("SelectGiaoVienChuNgiem'" + comboBox1.Text + "','"+nam+"'");
                textBox1.Text = r["hovaten"].ToString();
                textBox2.Text = r["magiaovien"].ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {
            export2Excel(dgvLopHoc1, @"D:\KTPMxuatFileExcel\LOPHOC\", "danhsachhocsinhtronglop");
            export2Excel(dgvLopHoc2, @"D:\KTPMxuatFileExcel\LOPHOC\", "danhsachgiaovientronglop");
            MessageBox.Show("Xuất file thành công");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmThemLop().ShowDialog();
        }
    }
}
