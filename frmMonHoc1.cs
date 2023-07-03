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
    public partial class frmMonHoc1 : Form
    {
        string nam = "";
        public frmMonHoc1(string mmh,string nam)
        {
            this.nam=nam;
            this.mmh = mmh;
            InitializeComponent();
            
        }
        string mmh;
        private void LoadDSMH()
        {
            string sql = "SelectMonHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = mmh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@nam",
                value =  nam
            });


            dataGridView1.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmMonHoc1_Load(object sender, EventArgs e)
        {   
            LoadDSMH();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                var ml=   dataGridView1.Rows[e.RowIndex].Cells["malop"].Value.ToString();
                var mgv= dataGridView1.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                // Cần truyền mã ssinh viên này vào formsinh vien;
                new frmMonHoc2(mmh,ml,mgv,nam).ShowDialog();
                LoadDSMH();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new frmMonHoc2(mmh, null, null,nam).ShowDialog();
            LoadDSMH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "DeleteMH";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = mmh
            });
            var rs = new Database().ExeCute(sql, lstPara);
            MessageBox.Show("Xóa thành công");
            this.Close();

        }
    }
}
