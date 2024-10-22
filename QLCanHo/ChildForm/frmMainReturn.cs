using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLCanHo.Class;

namespace QLCanHo.ChildForm
{
    public partial class frmMainReturn : Form
    {
        private void AddForm(Form f)
        {
            this.pnMain.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnMain.Controls.Add(f);
            f.Show();
        }
        public frmMainReturn()
        {
            InitializeComponent();
        }

        Database db;
        private void frmMainReturn_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadSoLieu("TongSoCanHo", lblSoCanHo);
            LoadSoLieu("DaDuocThue", lblDaDuocThue);
        }

        private void LoadSoLieu(string sql, Label lbl)
        {
            string sqlQuery = sql;
            var dt = db.SelectData(sqlQuery);

            if (dt != null && dt.Rows.Count > 0)
            {
                int totalCount = Convert.ToInt32(dt.Rows[0][0]);

                // Hiển thị kết quả trên label7
                lbl.Text = totalCount.ToString();
            }
            else
            {
                lbl.Text = "Không có dữ liệu";
            }
        }
    }
}
