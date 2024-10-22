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
    public partial class frmUpdateDienNuoc : Form
    {
        public frmUpdateDienNuoc()
        {
            InitializeComponent();
        }

        private Database db = new Database();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int tienDien = int.Parse(txtDien.Text);
            int tienNuoc = int.Parse(txtNuoc.Text);
            if (tienDien < 0 || tienNuoc < 0)
            {
                MessageBox.Show("Bạn nhập giá trị không chính xác");
            }
            else
            {
                List<CustomParameterInt> lst = new List<CustomParameterInt>
            {
                new CustomParameterInt
                {
                    key = "@giaDien",
                    value = tienDien
                },
                 new CustomParameterInt
                {
                    key = "@giaNuoc",
                    value = tienNuoc
                }
            };
                int ok = db.ExeCuteInt("CapNhatGiaDienNuoc", lst);
                if (ok > 0)
                {
                    MessageBox.Show($"Thực hiện thành công, giá điện hiện tại là {tienDien}vnđ, giá nước hiện tại là {tienNuoc}vnđ");
                }
                else
                {
                    MessageBox.Show("Thực hiện thất bạn");
                }
            }
        }

        private void frmUpdateDienNuoc_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtDien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
