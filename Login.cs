namespace QuanLyTruongHoc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string matkhau = "";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tendangnhap = textBox1.Text;
            matkhau = textBox2.Text;
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                
                 new CustomParameter()
                {
                    key = "@taikhoan",
                    value=textBox1.Text
                },
                  new CustomParameter()
                {
                    key = "@matkhau",
                    value=textBox2.Text
                },
            };
            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                
                Home f = new Home();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}