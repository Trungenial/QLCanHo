using QLCanHo.Class;
using QLCanHo.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCanHo.ChildForm
{
    public partial class frmHopDongThue : Form
    {
        private Database db;
        public frmHopDongThue()
        {
            InitializeComponent();
        }

        private List<KhachHang> lstKH;

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThue_Load(object sender, EventArgs e)
        {
            db = new Database();

            lstKH = new List<KhachHang>();

            var rs = db.SelectData("LoadAllDsCanHo");
            cbbPhong.DataSource = rs;
            cbbPhong.ValueMember = "ID";
            cbbPhong.DisplayMember = "TenCanHo";
            cbbPhong.SelectedIndex = -1;
            Console.WriteLine();
            DateTime dateTime = DateTime.Now.Date;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToString());
            dtpNgayThue.Text = dateTime.ToString("M/d/yyyy");
            dtpNgayTra.Text = dateTime.AddMonths(1).ToString("M/d/yyyy");


        }



        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DateTime ngayThue, ngayTra;
            try
            {
                ngayThue = DateTime.ParseExact(dtpNgayThue.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                ngayTra = DateTime.ParseExact(dtpNgayTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (ngayTra <= ngayThue)
                {
                    MessageBox.Show("Ngày thuê không được nhỏ hơn hoặc bằng ngày trả!", "WARNING!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày thuê hoặc ngày trả không hợp lệ");
                return;
            }


            int datCoc = 0;
            try
            {
                datCoc = int.Parse(txtDatCoc.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập tiền đặt cọc", "RÀNG BUỘC DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (cbbPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng thuê", "RÀNG BUỘC DỮ LIỆU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idPhong = cbbPhong.SelectedValue.ToString();


            int csDien = int.Parse(txtCSDien.Text);
            int csNuoc = int.Parse(txtCSNuoc.Text);
            int tienMang = int.Parse(txtTienMang.Text);
            int tienVeSinh = int.Parse(txtTienVeSinh.Text);


            if (lstKH.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin khách thuê", "Ràng buộc dữ liệu!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            List<CustomParameter> lst;

            //Bước 1: Khởi tạo hợp đồng
            lst = new List<CustomParameter>()
            {
                new CustomParameter
                {
                     key ="@idPhong",
                     value = idPhong
                },
                new CustomParameter
                {
                    key = "@datCoc",
                    value = datCoc.ToString()
                },
                 new CustomParameter
                {
                    key = "@TienVeSinh",
                    value = tienVeSinh.ToString()
                },
                new CustomParameter
                {
                    key = "@TienMang",
                    value = tienMang.ToString()
                }
            };
            if (db.ExeCute("TaoMoiHopDong", lst) != 1)
            {
                return;
            }


            //Bước 2: Khởi tạo chi thiết hợp đồng
            lst = new List<CustomParameter>()
            {
                new CustomParameter
                {
                    key = "@ngayBatDau",
                    value = ngayThue.ToString()
                },
                new CustomParameter
                {
                    key = "@ngayKetThuc",
                    value = ngayTra.ToString()
                },
                new CustomParameter
                {
                    key = "@CSD_Cu",
                    value = csDien.ToString()
                },
                new CustomParameter
                {
                    key = "@CSN_Cu",
                    value = csNuoc.ToString()
                }

            };

            if (db.ExeCute("TaoChiTietHopDong", lst) != 1)
            {
                return;
            }


            //Bước 3: Lưu trữ thông tin khách hàng

            foreach (var kh in lstKH)
            {
                lst = new List<CustomParameter>
                {
                    new CustomParameter
                    {
                        key = "@ho",
                        value = kh.Ho
                    },
                    new CustomParameter
                    {
                        key = "@tenDem",
                        value = kh.TenDem
                    },
                     new CustomParameter
                    {
                        key = "@ten",
                        value = kh.Ten
                    },
                      new CustomParameter
                    {
                        key = "@cmnd_cccd",
                        value = kh.CMND_CCCD
                    },
                       new CustomParameter
                    {
                        key = "@dienThoai",
                        value = kh.DienThoai
                    },
                    new CustomParameter
                    {
                        key = "@queQuan",
                        value = kh.QueQuan
                    },
                    new CustomParameter
                    {
                        key = "@hktt",
                        value = kh.HKTT
                    }
                };

                db.ExeCute("ThemKhachHang", lst);


            }

            MessageBox.Show("Tạo mới hợp đồng thuê trọ thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();




        }

        private void txtDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            var ho = txtHo.Text.Trim();
            var tendem = txtTenDem.Text.Trim();
            var ten = txtTen.Text.Trim();
            var CMND_CCCD = txtCMND.Text.Trim();
            var dienThoai = txtDienThoai.Text.Trim();
            var queQuan = txtQueQuan.Text.Trim();
            var HKTT = txtHKTT.Text.Trim();


            if (string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên khách hàng!", "Ràng buộc dữ liệu!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(CMND_CCCD))
            {
                MessageBox.Show("Vui lòng nhập thông tin CMND/CCCD", "Ràng buộc dữ liệu!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(queQuan) || string.IsNullOrEmpty(HKTT))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ HKTT và quê quán", "Ràng buộc dữ liệu!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            lstKH.Add(new KhachHang()
            {
                Ho = ho,
                TenDem = tendem,
                Ten = ten,
                CMND_CCCD = CMND_CCCD,
                DienThoai = dienThoai,
                QueQuan = queQuan,
                HKTT = HKTT
            });

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = lstKH;

            txtHo.Text = txtTenDem.Text = txtTen.Text = txtDienThoai.Text = txtCMND.Text = txtQueQuan.Text = txtHKTT.Text = null;
            txtHo.Select();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void txtHKTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtCSNuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
