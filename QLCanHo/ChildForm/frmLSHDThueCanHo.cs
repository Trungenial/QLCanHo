using OfficeOpenXml.ExternalReferences;
using QLCanHo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace QLCanHo.ChildForm
{
    public partial class frmLSHDThueCanHo : Form
    {
        private Database db;
        public frmLSHDThueCanHo()
        {
            InitializeComponent();
        }

        private void frmLSThueCanHo_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLSDSThuePhong();
        }
        private void LoadLSDSThuePhong()
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
            dgvLSThueCanHo.AutoGenerateColumns = false;
            var rs = db.SelectData("[LoadLSHopDong]", lstPra);
            dgvLSThueCanHo.DataSource = rs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLSDSThuePhong();
        }


        private void dgvLSThueCanHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SaveFileDialog sf;
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                ToExcel.DgvToExcel(dgvLSThueCanHo, sf.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
