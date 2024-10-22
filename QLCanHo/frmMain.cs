using QLCanHo.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace QLCanHo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void AddForm(Form f)
        {
            this.pnMain.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            f.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMainReturn f = new frmMainReturn();
            AddForm(f);
        }

        private void lstInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (lstInfo.SelectedIndex != -1)
            {
                string selectedItem = lstInfo.SelectedItem.ToString();

                // Tạo form mới
                frmLoaiPhong f = new frmLoaiPhong();
                AddForm(f);
            }*/
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiCanHo f = new frmLoaiCanHo();
            AddForm(f);
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiCanHo f = new frmLoaiCanHo();
            AddForm(f);
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmMainReturn f = new frmMainReturn();
            AddForm(f);
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LockApplication()
        {
            // Tạo một form modal có tên là "lockForm"
            Form lockForm = new Form();
            lockForm.FormBorderStyle = FormBorderStyle.None;
            lockForm.WindowState = FormWindowState.Maximized;
            lockForm.BackColor = Color.Black;
            lockForm.Opacity = 0.5;
            lockForm.ShowDialog();
            this.WindowState = FormWindowState.Minimized;
        }



        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
        }

        private void loạiPhòngToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmLoaiCanHo f = new frmLoaiCanHo();
            AddForm(f);
        }

        private void phòngToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmCanHo f = new frmCanHo();
            AddForm(f);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            AddForm(f);
        }

        private void dangxuatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
            }
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picQuanLyCanHo_Click_1(object sender, EventArgs e)
        {
            frmMainReturn f = new frmMainReturn();
            AddForm(f);
        }

        private void loạiPhòngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLoaiCanHo f = new frmLoaiCanHo();
            AddForm(f);
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu f = new frmDichVu();
            AddForm(f);
        }

        private void thuêTrảCănHộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThueCanHo f = new frmThueCanHo();
            AddForm(f);
        }

        private void thooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin f = new frmThongTin();
            AddForm(f);
        }

        private void lịchSửThuêCănHộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLSHDThueCanHo f = new frmLSHDThueCanHo();
            AddForm(f);
        }

        private void cậpNhậtGiáĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateDienNuoc f = new frmUpdateDienNuoc();
            AddForm(f);
        }

        private void lịchSửHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLSHDThueCanHo f = new frmLSHDThueCanHo();
            AddForm(f);
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
