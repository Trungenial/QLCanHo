using QLCanHo.Class;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace QLCanHo.ChildForm
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        private void btnXaxNhan_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string laiMatKhauMoi = txtLaiMatKhauMoi.Text;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            if (matKhauCu == "" || matKhauMoi == "" || laiMatKhauMoi == "")
            {
                if (matKhauCu == "")
                    errorProvider1.SetError(txtMatKhauCu, "Bạn chưa nhập Email!");
                if (matKhauCu == "")
                    errorProvider2.SetError(txtMatKhauCu, "Bạn chưa nhập mật khẩu!");
                if (matKhauMoi == "")
                    errorProvider3.SetError(txtMatKhauMoi, "Bạn chưa nhập mật khẩu mới!");
                if (laiMatKhauMoi == "")
                    errorProvider4.SetError(txtMatKhauMoi, "Bạn chưa nhập lại mật khẩu mới!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "' and MatKhau = '" + matKhauCu + "'";
                if (modify.TaiKhoan("Select * from TaiKhoan where Email = '" + email + "'").Count == 0) { MessageBox.Show("Email đã chưa đăng ký"); return; }
                if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; };
                if (!CheckAccount(matKhauMoi)) { MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; };
                if (modify.TaiKhoan(query).Count > 0)
                {
                    if (laiMatKhauMoi != matKhauMoi) { MessageBox.Show("Nhập lại mật khẩu mới không giống mật khẩu mới, vui lòng nhập lại!"); return; }
                    try
                    {
                        string strDoiMatKhau = "UPDATE TaiKhoan SET MatKhau ='" + matKhauMoi + "'WHERE Email ='" + email + "';";
                        modify.Command(strDoiMatKhau);
                        modify.Command(strDoiMatKhau);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo!");
                    }
                    catch
                    {
                        MessageBox.Show("Đổi thất bại", "Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác!", "Thông báo!");
                }

            }
        }

        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
