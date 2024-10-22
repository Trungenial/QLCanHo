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
    public partial class frmUpdateCanHo : Form
    {

        private string idCanHo;
        private Database db;
        public frmUpdateCanHo(string idCanHo)
        {
            this.idCanHo = idCanHo;
            InitializeComponent();
        }

        private void frmXuLyCanHo_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiCanHo();

            if (string.IsNullOrEmpty(idCanHo))//nếu idcanho đc truyền qua là null = trường hợp thêm mới
            {
                lblTitle.Text = "Thêm phòng mới";
            }
            else//nếu idcanho khác null <=> trường hợp cập nhật thông tin căn hộ
            {
                lblTitle.Text = "Cập nhật thông tin phòng";

                //vì căn hộ được xác định qua id nên chúng ta cần truyền tham số là giá trị của id phòng vào
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idCanHo",
                        value = idCanHo
                    }
                };
                var canHo = db.SelectData("[selectCanHo]", lstPara).Rows[0];// sử dụng hàm selectdata trong class datatabase để lấy dữ liệu căn hộ

                //kết quả trả về là 1 datatable chỉ gồm 1 hàng chính là hàng có chỉ số hàng bằng 0

                //set các dữ liệu lấy đc cho các component trên form frmXyLyPhong
                cbbLoaiCanHo.SelectedValue = canHo["IDLoaiCanHo"].ToString();//set id căn hộ cho combobox
                txtTenCanHo.Text = canHo["TenCanHo"].ToString();//set giá trị tên phòng cho textbox txtTenCanHo
                if (canHo["trangthai"].ToString() == "1")//set trạng thái hoạt động cho checkbox ckbHoatDong
                {
                    ckbHoatDong.Checked = true;
                }
                else
                {
                    ckbHoatDong.Checked = false;
                }
            }
        }

        private void LoadLoaiCanHo()
        {
            var dt = db.SelectData("loadDsLoaiCanHo");
            cbbLoaiCanHo.DataSource = dt;
            cbbLoaiCanHo.DisplayMember = "TenLoaiCanHo";
            cbbLoaiCanHo.ValueMember = "ID";
        }

        private void frmXuLyCanHo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(); //đóng form lại
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbbLoaiCanHo.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại căn hộ", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var idLoaiCanHo = cbbLoaiCanHo.SelectedValue.ToString();
            var tenCanHo = txtTenCanHo.Text.Trim();
            var trangThai = ckbHoatDong.Checked ? 1 : 0;

            if (string.IsNullOrEmpty(tenCanHo))
            {
                MessageBox.Show("Vui lòng nhập tên căn hộ", "Ràng buộc dữ liệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCanHo.Select();
                return;
            }


            if (string.IsNullOrEmpty(idCanHo))//trường hợp thêm mới căn hộ không có idcanho <=> null
            {
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiCanHo",
                        value = idLoaiCanHo
                    },
                    new CustomParameter()
                    {
                        key = "@tenCanHo",
                        value = tenCanHo
                    },
                    new CustomParameter()
                    {
                        key = "@trangThai",
                        value = trangThai.ToString()
                    }
                };
                var rs = db.ExeCute("[themMoiCanHo]", lstPra);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới căn hộ thành công!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset lại các giá trị của component sau khi thêm mới thành công
                    txtTenCanHo.Text = null;
                    cbbLoaiCanHo.SelectedIndex = 0;
                }
            }
            else//trường hợp cập nhật căn hộ đã tồn tại <=> idCanHo có giá trị # null
            {
                //xử lý trường hợp cập nhật khi click vào button btnXacNhan
                //bên proc có 4 tham số đầu vào
                //vì vậy ở đây chúng ta cũng cần truyền 4 tham số tương ứng
                var lstPara = new List<CustomParameter>()
               {
                   new CustomParameter
                   {
                       key = "@idCanHo",
                       value = idCanHo
                   },
                   new CustomParameter
                   {
                       key = "@tenCanHo",
                       value = txtTenCanHo.Text
                   },
                   new CustomParameter
                   {
                       key = "@idLoaiCanHo",
                       value = cbbLoaiCanHo.SelectedValue.ToString()
                   },
                   new CustomParameter
                   {
                       key = "@trangThai",
                       value = trangThai.ToString()
                   }
               };
                var kq = db.ExeCute("updateCanHo", lstPara);
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thông tin căn hộ thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo thành công
                    this.Dispose();//đóng form frmXyLyCanHo
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin căn hộ không thành công!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);//hiện thông báo không thành công
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose(); //đóng form lại
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
