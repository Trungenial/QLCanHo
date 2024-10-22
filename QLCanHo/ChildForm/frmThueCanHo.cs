using QLCanHo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCanHo.ChildForm
{
    public partial class frmThueCanHo : Form
    {
        private Database db;
        public frmThueCanHo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmHopDongThue().ShowDialog();
            LoadDSThuePhong();
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSThuePhong();
        }

        private void LoadDSThuePhong()
        {
            var tuKhoa = txtTuKhoa.Text.Trim();
            var lstPra = new List<CustomParameter>()
            {
                new CustomParameter
                {
                    key = "@tuKhoa",
                    value = tuKhoa,
                }
            };
            dgvThueCanHo.AutoGenerateColumns = false;
            var rs = db.SelectData("[LoadDSHopDong]", lstPra);
            dgvThueCanHo.DataSource = rs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDSThuePhong();
        }

        private void dgvThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvThueCanHo.Columns["btnThanhToan"].Index)
                {
                    var IDHopDong = int.Parse(dgvThueCanHo.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    var CSD_Cu = int.Parse(dgvThueCanHo.Rows[e.RowIndex].Cells["CSD_Cu"].Value.ToString());
                    var CSN_Cu = int.Parse(dgvThueCanHo.Rows[e.RowIndex].Cells["CSN_Cu"].Value.ToString());

                    new frmChotDienNuoc(IDHopDong, CSD_Cu, CSN_Cu).ShowDialog();
                    LoadDSThuePhong();
                }

            }
        }

        private void dgvThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SaveFileDialog sf;
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                ToExcel.DgvToExcel(dgvThueCanHo, sf.FileName);
            }
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
