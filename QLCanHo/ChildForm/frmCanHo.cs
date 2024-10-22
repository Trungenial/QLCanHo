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

namespace QLCanHo.ChildForm
{
    public partial class frmCanHo : Form
    {

        private Database db;
        private int rowIndex = -1;//biến lưu chỉ số căn hộ của căn hộ đc chọn
        public frmCanHo()
        {
            InitializeComponent();
        }

        private void frmCanHo_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDsCanHo();

            //dat lai ten cot
            dgvCanHo.Columns["tenloaicanho"].HeaderText = "Loại căn hộ";
            dgvCanHo.Columns["tencanho"].HeaderText = "Căn hộ";
            dgvCanHo.Columns["dongia"].HeaderText = "Đơn giá";
            dgvCanHo.Columns["trangthai"].HeaderText = "Trạng thái";

            //set kích thước các cột
            dgvCanHo.Columns["id"].Width = 50;
            dgvCanHo.Columns["tenloaicanho"].Width = 200;
            dgvCanHo.Columns["dongia"].Width = 200;
            dgvCanHo.Columns["trangthai"].Width = 200;

            dgvCanHo.Columns["tencanho"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên căn hộ tự động co giãn theo form 


            //căn chỉnh vị trí của cột
            dgvCanHo.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//căn phải cho cột đơn giá

            //định dạng phần nghìn cho cột đơn giá căn hộ
            dgvCanHo.Columns["dongia"].DefaultCellStyle.Format = "N0";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmUpdateCanHo(null).ShowDialog();//truyền tham số null vào để xác định trường hợp thêm mới căn
            LoadDsCanHo();
        }

        private void LoadDsCanHo()
        {
            var timKiem = txtTimKiem.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };

            var dt = db.SelectData("LoadDsCanHo", lstPra);

            dgvCanHo.DataSource = dt;
        }
        private void LocDsCanHo(string sql)
        {
            var dt = db.SelectData(sql);

            dgvCanHo.DataSource = dt;
        }

        private void dgvCanHo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id căn hộ đc chọn
            var idCanHo = dgvCanHo.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new frmUpdateCanHo(idCanHo).ShowDialog();//truyền idCanHo đc chọn qua form frmXuLyCanHo để xác định trường hợp cập nhật căn hộ
            LoadDsCanHo();
        }

        private void dgvCanHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id căn hộ cần xóa trong sự kiện cell click của datagridview
            rowIndex = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kiểm tra xem rowIndex có phải < 0 hay không
            //nếu < 0 có nghĩa chưa có phòng nào được chọn để xóa cả vì chỉ số dòng phải bắt đầu từ 0
            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn căn hộ cần xóa", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//nếu gặp trường hợp chưa có căn hộ nào đc chọn để xóa thì sẽ dừng chương trình
            }

            //nếu có căn hộ được chọn để xóa ( ngược lại trường hợp trên) thì hiện câu hỏi xác nhận xóa
            if (MessageBox.Show("Bạn có chắc muốn xóa căn hộ " + dgvCanHo.Rows[rowIndex].Cells["tencanho"].Value.ToString() + " hay không?", "Xác nhận xóa căn hộ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //tương tự cần truyền giá trị id căn hộ cần xóa vào proc vừa mới khai báo
                var lstPara = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        key = "@idCanHo",
                        value = dgvCanHo.Rows[rowIndex].Cells["ID"].Value.ToString()
                    }
                };
                var kq = db.ExeCute("deleteCanHo", lstPara);

                //hiển thị thông báo trong trường hợp xóa thành công
                if (kq == 1)
                {
                    MessageBox.Show("Xóa phòng thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //sau khi xóa thành công thì load lại ds căn hộ hiện tại bằng cách gọi lại hàm  LoadDsCanHo
                    LoadDsCanHo();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDsCanHo();
        }

        private void btnCanHoDangHoatDong_Click(object sender, EventArgs e)
        {
            LocDsCanHo("CanHoDangHoatDong");
        }

        private void btnCanHoKhongHoatDong_Click(object sender, EventArgs e)
        {
            LocDsCanHo("CanHoKhongHoatDong");
        }

        SaveFileDialog sf;
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                ToExcel.DgvToExcel(dgvCanHo, sf.FileName);
            }
        }

        private void dgvCanHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


