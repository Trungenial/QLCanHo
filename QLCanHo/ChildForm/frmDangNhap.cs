using QLCanHo.ChildForm;
using QLCanHo.Class;

namespace QLCanHo
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy f = new frmDangKy();
            f.Show();
            this.Hide();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                if (txtTaiKhoan.Text == "")
                    errorProvider1.SetError(txtTaiKhoan, "Bạn chưa nhập tên tài khoản!");
                if (txtMatKhau.Text == "")
                    errorProvider2.SetError(txtMatKhau, "Bạn chưa nhập mật khẩu!");
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan ='"+taiKhoan+"'and MatKhau = '"+matKhau+"'";
                if (modify.TaiKhoan(query).Count > 0)
                {
                MessageBox.Show("Đăng nhập thành công", "Thông báo!");
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
                this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo!");
                } 
                    
            }
        }


        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.ShowDialog();
        }
    }
}
