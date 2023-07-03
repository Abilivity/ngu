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
    public partial class frmThemGVVaoLop : Form
    {
        string nam = "";
        public frmThemGVVaoLop(string mlh,string nam)
        {
            this.nam = nam;
            this.mlh = mlh;
            InitializeComponent();
        }
        string mlh;

        private void frmThemGVVaoLop_Load(object sender, EventArgs e)
        {
            string sql = "selectDSGIAOVIEN";
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string sql = "Themgiaovien";
                var mlhnow = dataGridView1.Rows[e.RowIndex].Cells["malop"].Value.ToString();
                var mgv = dataGridView1.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                var mmh = dataGridView1.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@malop",
                    value = mlh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@malop1",
                    value = mlhnow
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
                }
                else
                {
                    MessageBox.Show("Thực thi truy vấn thất bại");
                }
            }
        }
    }
}
