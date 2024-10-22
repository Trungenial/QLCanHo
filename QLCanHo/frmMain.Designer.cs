using System.Windows.Forms;

namespace QLCanHo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            miniToolStrip = new MenuStrip();
            picBack = new PictureBox();
            pnMain = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            dangxuatToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            cănhộToolStripMenuItem = new ToolStripMenuItem();
            loạiCănHộToolStripMenuItem = new ToolStripMenuItem();
            dịchVụToolStripMenuItem = new ToolStripMenuItem();
            tácVToolStripMenuItem = new ToolStripMenuItem();
            thuêTrảCănHộToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtGiáĐiệnNướcToolStripMenuItem = new ToolStripMenuItem();
            lịchSửHợpĐồngToolStripMenuItem = new ToolStripMenuItem();
            thooToolStripMenuItem = new ToolStripMenuItem();
            picQuanLyCanHo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQuanLyCanHo).BeginInit();
            SuspendLayout();
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(3, 200);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.RenderMode = ToolStripRenderMode.Professional;
            miniToolStrip.Size = new Size(132, 489);
            miniToolStrip.TabIndex = 2;
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = (Image)resources.GetObject("picBack.Image");
            picBack.Location = new Point(101, 3);
            picBack.Name = "picBack";
            picBack.Size = new Size(57, 58);
            picBack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBack.TabIndex = 26;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(0, 0, 0, 0);
            pnMain.Dock = DockStyle.Right;
            pnMain.Location = new Point(164, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(999, 667);
            pnMain.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Controls.Add(picBack);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(picQuanLyCanHo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 667);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(2, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 544);
            panel2.TabIndex = 21;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, tácVToolStripMenuItem, thooToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(157, 544);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, dangxuatToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13.8F);
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(142, 33);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            hệThốngToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(239, 34);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click_1;
            // 
            // dangxuatToolStripMenuItem
            // 
            dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            dangxuatToolStripMenuItem.Size = new Size(239, 34);
            dangxuatToolStripMenuItem.Text = "Đăng xuất";
            dangxuatToolStripMenuItem.Click += dangxuatToolStripMenuItem_Click_1;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(239, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click_1;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cănhộToolStripMenuItem, loạiCănHộToolStripMenuItem, dịchVụToolStripMenuItem });
            danhMụcToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13.8F);
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(142, 33);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            danhMụcToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            danhMụcToolStripMenuItem.Click += danhMụcToolStripMenuItem_Click;
            // 
            // cănhộToolStripMenuItem
            // 
            cănhộToolStripMenuItem.Name = "cănhộToolStripMenuItem";
            cănhộToolStripMenuItem.Size = new Size(329, 34);
            cănhộToolStripMenuItem.Text = "Căn hộ";
            cănhộToolStripMenuItem.Click += phòngToolStripMenuItem_Click_2;
            // 
            // loạiCănHộToolStripMenuItem
            // 
            loạiCănHộToolStripMenuItem.Name = "loạiCănHộToolStripMenuItem";
            loạiCănHộToolStripMenuItem.Size = new Size(329, 34);
            loạiCănHộToolStripMenuItem.Text = "Loại căn hộ";
            loạiCănHộToolStripMenuItem.Click += loạiPhòngToolStripMenuItem_Click_1;
            // 
            // dịchVụToolStripMenuItem
            // 
            dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            dịchVụToolStripMenuItem.Size = new Size(329, 34);
            dịchVụToolStripMenuItem.Text = "Dịch vụ";
            dịchVụToolStripMenuItem.Click += dịchVụToolStripMenuItem_Click;
            // 
            // tácVToolStripMenuItem
            // 
            tácVToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thuêTrảCănHộToolStripMenuItem, cậpNhậtGiáĐiệnNướcToolStripMenuItem, lịchSửHợpĐồngToolStripMenuItem });
            tácVToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13.8F);
            tácVToolStripMenuItem.Name = "tácVToolStripMenuItem";
            tácVToolStripMenuItem.Size = new Size(142, 33);
            tácVToolStripMenuItem.Text = "Tác vụ";
            tácVToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // thuêTrảCănHộToolStripMenuItem
            // 
            thuêTrảCănHộToolStripMenuItem.Name = "thuêTrảCănHộToolStripMenuItem";
            thuêTrảCănHộToolStripMenuItem.Size = new Size(430, 34);
            thuêTrảCănHộToolStripMenuItem.Text = "Thanh toán - Thuê - Trả căn hộ";
            thuêTrảCănHộToolStripMenuItem.Click += thuêTrảCănHộToolStripMenuItem_Click;
            // 
            // cậpNhậtGiáĐiệnNướcToolStripMenuItem
            // 
            cậpNhậtGiáĐiệnNướcToolStripMenuItem.Name = "cậpNhậtGiáĐiệnNướcToolStripMenuItem";
            cậpNhậtGiáĐiệnNướcToolStripMenuItem.Size = new Size(430, 34);
            cậpNhậtGiáĐiệnNướcToolStripMenuItem.Text = "Cập nhật giá điện - nước";
            cậpNhậtGiáĐiệnNướcToolStripMenuItem.Click += cậpNhậtGiáĐiệnNướcToolStripMenuItem_Click;
            // 
            // lịchSửHợpĐồngToolStripMenuItem
            // 
            lịchSửHợpĐồngToolStripMenuItem.Name = "lịchSửHợpĐồngToolStripMenuItem";
            lịchSửHợpĐồngToolStripMenuItem.Size = new Size(430, 34);
            lịchSửHợpĐồngToolStripMenuItem.Text = "Lịch sử hợp đồng";
            lịchSửHợpĐồngToolStripMenuItem.Click += lịchSửHợpĐồngToolStripMenuItem_Click;
            // 
            // thooToolStripMenuItem
            // 
            thooToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 13.8F);
            thooToolStripMenuItem.Name = "thooToolStripMenuItem";
            thooToolStripMenuItem.Size = new Size(142, 33);
            thooToolStripMenuItem.Text = "Thông tin";
            thooToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            thooToolStripMenuItem.Click += thooToolStripMenuItem_Click;
            // 
            // picQuanLyCanHo
            // 
            picQuanLyCanHo.Cursor = Cursors.Hand;
            picQuanLyCanHo.Image = (Image)resources.GetObject("picQuanLyCanHo.Image");
            picQuanLyCanHo.Location = new Point(2, 67);
            picQuanLyCanHo.Name = "picQuanLyCanHo";
            picQuanLyCanHo.Size = new Size(154, 144);
            picQuanLyCanHo.SizeMode = PictureBoxSizeMode.StretchImage;
            picQuanLyCanHo.TabIndex = 20;
            picQuanLyCanHo.TabStop = false;
            picQuanLyCanHo.Click += picQuanLyCanHo_Click_1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1163, 667);
            Controls.Add(panel1);
            Controls.Add(pnMain);
            Font = new Font("Segoe UI", 10.2F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = miniToolStrip;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý căn hộ";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQuanLyCanHo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip miniToolStrip;
        private PictureBox picBack;
        private Panel pnMain;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem dangxuatToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem cănhộToolStripMenuItem;
        private ToolStripMenuItem dịchVụToolStripMenuItem;
        private ToolStripMenuItem loạiCănHộToolStripMenuItem;
        private ToolStripMenuItem tácVToolStripMenuItem;
        private ToolStripMenuItem thuêTrảCănHộToolStripMenuItem;
        private ToolStripMenuItem thooToolStripMenuItem;
        private PictureBox picQuanLyCanHo;
        private ToolStripMenuItem cậpNhậtGiáĐiệnNướcToolStripMenuItem;
        private ToolStripMenuItem lịchSửHợpĐồngToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;

    }
}