using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLCanHo.Class;

namespace QLCanHo.ChildForm
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string nlmatkhau = txtNhapLaiMatKhau.Text;
            string email = txtEmail.Text;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtNhapLaiMatKhau.Text == "" || txtEmail.Text == "")
            {
                if (txtTaiKhoan.Text == "")
                    errorProvider1.SetError(txtTaiKhoan, "Bạn chưa nhập tên tài khoản!");
                if (txtMatKhau.Text == "")
                    errorProvider2.SetError(txtMatKhau, "Bạn chưa nhập mật khẩu!");
                if (txtNhapLaiMatKhau.Text == "")
                    errorProvider3.SetError(txtNhapLaiMatKhau, "Bại chưa nhập lại mật khẩu!");
                if (txtNhapLaiMatKhau.Text == "")
                    errorProvider4.SetError(txtEmail, "Bại chưa nhập email!");
                return;
            }
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; };
            if (!CheckAccount(matKhau)) { MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; };
            if (nlmatkhau != matKhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!");return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; };
            if (modify.TaiKhoan("Select * from TaiKhoan where Email = '"+email+"'").Count != 0) { MessageBox.Show("Email đã được đăng ký, vui lòng đăng ký Email khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('"+tentk+"','"+matKhau+"','"+email+"')";
                modify.Command(query);
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
            }

            {
                MessageBox.Show("Đăng ký thành công", "Thông báo!");
                this.Hide();
                frmDangNhap f = new frmDangNhap();
                f.ShowDialog();
                this.Close();
            }
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        public bool CheckAccount(string ac)     
        {
            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }
    }
}
