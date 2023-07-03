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

namespace QuanLyTruongHoc
{
    public partial class frmDiem1 : Form
    {
        string nam = "";
        public frmDiem1(string ml,string mmh,string nam)
        {
            this.nam = nam;
            this.ml = ml;
            this.mmh = mmh;
            InitializeComponent();
        }
        string ml;
        string mmh;
        private void LoadDSHS1()
        {
            string sql = "SelectDiem1";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value = ml
            });
            
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });
            dataGridView1.DataSource = new Database().SelectData(sql, lstPara);
            //int rowCount1 = dataGridView1.Rows.Count;
            //this.Controls.Add(dataGridView1);
            
            //for (int i = 0; i < rowCount1; i++)
            //{

            //    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            //}
        }
        private void frmDiem1_Load(object sender, EventArgs e)
        {
            LoadDSHS1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                var mhs = dataGridView1.Rows[e.RowIndex].Cells["mahocsinh"].Value.ToString();
              
                string sql = "SelectDiem2";
                List<CustomParameter> lstPara = new List<CustomParameter>();
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
                MessageBox.Show("Thêm thành công ");
                int CellCount2 = 4;
                
                for (int i = 0; i < CellCount2; i++)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[i].Value = " ";
                    

                }
                

            }
        }
    }
}
