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
    public partial class frmThemHSVaoLop : Form
    {
        string nam = "";
        public frmThemHSVaoLop(string mlh,string nam)
        {
            this.nam = nam; 
            this.mlh = mlh;
            InitializeComponent();
        }
        string mlh;

        private void frmThemHSVaoLop_Load(object sender, EventArgs e)
        {
            string sql = "selectDSHOCSINH";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@malop",
                value = mlh.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value = nam
            });
            dataGridView1.DataSource = new Database().SelectData(sql, lstPara);
            int rowCount2 = dataGridView1.Rows.Count;
            this.Controls.Add(dataGridView1);
            //textBox1.Text = rowCount2.ToString();

            //for (int i = 0; i < rowCount2; i++)
            //{

            //    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string sql = "Themhocsinh";
                var mhs = dataGridView1.Rows[e.RowIndex].Cells["mahocsinh"].Value.ToString();
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@malop",
                    value = mlh
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
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mhs))
                    {
                        MessageBox.Show("Thêm mới học sinh thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mới học sinh thành công");
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thực thi truy vấn thất bại");
                }

            }
        }
    }
}
