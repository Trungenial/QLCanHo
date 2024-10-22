using QLCanHo.Class;
using System.Data;
using System.Windows.Forms;

namespace QLCanHo.ChildForm
{
    public partial class frmThanhToan : Form
    {
        private string IDThueCanHo;
        private Database db;
        public frmThanhToan(string IDThueCanHo)
        {
            this.IDThueCanHo = IDThueCanHo;
            db = new Database();
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        DataRow dr;
        private void LoadHopDongThuePhong()
        {
            List<CustomParameter> lst = new List<CustomParameter> {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = IDThueCanHo
                }
            };

            dr = db.SelectData("LoadHopDong", lst).Rows[0];
            lblCanHo.Text = dr["TenCanHo"].ToString();
            lblTienPhong.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["GiaCanHo"].ToString()));
            lblTienDien.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienDien"].ToString()));
            lblTienNuoc.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienNuoc"].ToString()));
            lblTienVeSinh.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienVeSinh"].ToString()));
            lblTienMang.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TienMang"].ToString()));
            lblTongTienThang.Text = string.Format("{0:N0} VNĐ", int.Parse(dr["TongTienCuaThang"].ToString()));
            lblSoDuNo.Text = string.Format("{0:N0} VNĐ", dr["SoNoConThieu"].ToString().Length == 0 ? 0 : int.Parse(dr["SoNoConThieu"].ToString()));
            lblTongTienCanThanhToan.Text = string.Format("{0:N0} VNĐ", dr["TongTienPhaiTra"].ToString().Length == 0 ? int.Parse(dr["TongTienCuaThang"].ToString()) : int.Parse(dr["TongTienPhaiTra"].ToString()));
            lblConLai.Text = string.Format("{0:N0} VNĐ", dr["TongTienPhaiTra"].ToString().Length == 0 ? int.Parse(dr["TongTienCuaThang"].ToString()) : int.Parse(dr["TongTienPhaiTra"].ToString()));
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadHopDongThuePhong();
        }

        private void txtThanhToan_KeyUp(object sender, KeyEventArgs e)
        {
            var ctt = lblTongTienCanThanhToan.Text;
            var soNo = int.Parse(ctt.Split(' ')[0].Replace(",", ""));

            lblConLai.Text = string.Format("{0:N0} VNĐ", soNo - int.Parse(txtThanhToan.Text.Trim().Length == 0 ? "0" : txtThanhToan.Text));
        }

        private void txtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        private void btnThanhToanTraPhong_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtThanhToan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền cần thanh toán!");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@Id",
                    value = IDThueCanHo
                },
                 new CustomParameter
                 {
                     key = "@SoTien",
                     value = txtThanhToan.Text
                 }
            };

            int ct = dr["TongTienPhaiTra"].ToString().Length == 0 ? int.Parse(dr["TongTienCuaThang"].ToString()) : int.Parse(dr["TongTienPhaiTra"].ToString());
            int t = int.Parse(txtThanhToan.Text);
            if (t != ct)
            {
                errorProvider1.SetError(txtThanhToan, "Bạn chưa nhập đủ tiền cần thanh toán để kết thúc hợp đồng");
            }
            else if (t == ct)
            {
                var kq = db.ExeCute("ThanhToanKetThuc", lst);
                if (kq >= 1)
                {
                    MessageBox.Show("Thanh toán thành công!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*           this.Dispose();
                       new frmTraCanHo(IDThueCanHo).ShowDialog();
           */

        }

        private void btnThanhToanGiaHan_Click(object sender, EventArgs e)
        {
            if (txtThanhToan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền cần thanh toán!");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@Id",
                    value = IDThueCanHo
                },
                 new CustomParameter
                 {
                     key = "@SoTien",
                     value = txtThanhToan.Text
                 }
            };

            var kq = db.ExeCute("[ThanhToanGiaHan]", lst);
            if (kq >= 1)
            {
                MessageBox.Show("Thanh toán thành công!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "SUCCESSFULLY!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }
    }
}
