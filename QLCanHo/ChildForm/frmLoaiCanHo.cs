using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCanHo.Class;
using static System.Windows.Forms.DataFormats;

namespace QLCanHo.ChildForm
{
    public partial class frmLoaiCanHo : Form
    {

        public frmLoaiCanHo()
        {
            InitializeComponent();
        }

        private Database db;
        private int xacNhan = 0;
        private int maLoaiCanHo = 0;


        private void frmLoaiPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainReturn f = new frmMainReturn();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xacNhan = 1;
            txtDonGia.ReadOnly = false;
            txtTenLoaiCanHo.ReadOnly = false;

            txtDonGia.Text = "0";
            txtTenLoaiCanHo.Text = null;

            btnSua.Enabled = btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void LoadDsLoaiCanHo()
        {

            dgvDsLoaiCanHo.DataSource = db.SelectData("loadDsLoaiCanHo");
        }

        private void frmLoaiCanHo_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = btnThem.Enabled = true;
            btnLuu.Enabled = false;

            db = new Database();

            LoadDsLoaiCanHo();
            dgvDsLoaiCanHo.Columns[0].Width = 100;//set bề rộng cho cột id loại phòng
            dgvDsLoaiCanHo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiCanHo.Columns[0].HeaderText = "Mã loại";

            dgvDsLoaiCanHo.Columns[2].Width = 200;
            dgvDsLoaiCanHo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDsLoaiCanHo.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDsLoaiCanHo.Columns[2].HeaderText = "Đơn giá";

            dgvDsLoaiCanHo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDsLoaiCanHo.Columns[1].HeaderText = "Tên loại căn hộ";

            txtDonGia.ReadOnly = true;
            dgvDsLoaiCanHo.ReadOnly = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDsLoaiCanHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maLoaiCanHo = int.Parse(dgvDsLoaiCanHo.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenLoaiCanHo.Text = dgvDsLoaiCanHo.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDsLoaiCanHo.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xacNhan = -1;
            txtDonGia.ReadOnly = false;
            txtTenLoaiCanHo.ReadOnly = false;

            btnSua.Enabled = btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var tenLoaiCanHo = txtTenLoaiCanHo.Text.Trim();
            var donGia = int.Parse(txtDonGia.Text);


            //ràng buộc dữ liệu            

            if (string.IsNullOrEmpty(tenLoaiCanHo))
            {
                MessageBox.Show("Vui lòng nhập tên loại căn hộ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngang đây
            }

            if (donGia < 1000000)
            {
                MessageBox.Show("Đơn giá tối thiểu phải là 1000000", "Ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngang đây
            }

            var prList = new List<CustomParameter>();

            if (xacNhan == 1)//trường hợp thêm mới loại căn hộ
            {
                prList.Add(new CustomParameter
                {
                    key = "@tenLoaiCanHo",
                    value = tenLoaiCanHo
                });
                prList.Add(new CustomParameter
                {
                    key = "@donGia",
                    value = donGia.ToString()
                });
                var rs = db.ExeCute("[themLoaiCanHo]", prList);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới loại căn hộ thành công!", "Successfully!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
           if (xacNhan == -1)//cập nhật phòng trọ
            {
                if (maLoaiCanHo == 0)
                {
                    MessageBox.Show("Vui lòng chọn phòng cần cập nhật", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;//dừng chương trình ngang đây
                }

                prList.Add(new CustomParameter()
                {
                    key = "@idLoaiCanHo",
                    value = maLoaiCanHo.ToString()
                });
                prList.Add(new CustomParameter
                {
                    key = "@tenLoaiCanHo",
                    value = tenLoaiCanHo
                });
                prList.Add(new CustomParameter
                {
                    key = "@donGia",
                    value = donGia.ToString()
                });
                var rs = db.ExeCute("[capNhatLoaiCanHo]", prList);
                if (rs == 1)
                {
                    MessageBox.Show("Cập nhật loại căn hộ thành công!", "Successfully!!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            LoadDsLoaiCanHo();
            txtDonGia.Text = "0";
            txtTenLoaiCanHo.Text = null;
            maLoaiCanHo = 0;
            txtDonGia.ReadOnly = true;
            txtTenLoaiCanHo.ReadOnly = true;

            btnSua.Enabled = btnThem.Enabled = true;
            btnLuu.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maLoaiCanHo == 0)
            {
                MessageBox.Show("Vui lòng chọn loại căn hộ cần xóa", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa loại căn hộ này hay không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiCanHo",
                        value = maLoaiCanHo.ToString()
                    }
                };
                var rs = db.ExeCute("xoaLoaiCanHo", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa loại căn hộ thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsLoaiCanHo();
                    maLoaiCanHo = 0;//reset mã loại căn hộ (id  loại căn hộ về giá trị mặc định)
                }
            }
        }

        SaveFileDialog sf;
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                ToExcel.DgvToExcel(dgvDsLoaiCanHo, sf.FileName);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenLoaiCanHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbLoaiCanHo_Enter(object sender, EventArgs e)
        {

        }
    }
}
