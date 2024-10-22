namespace QLCanHo.ChildForm
{
    partial class frmCanHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCanHo));
            btnXoa = new Button();
            btnThemMoi = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKienCanHo = new Label();
            label2 = new Label();
            dgvCanHo = new DataGridView();
            btnCanHoKhongHoatDong = new Button();
            btnCanHoDangHoatDong = new Button();
            btnXuatExcel = new Button();
            grbLocCanHo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCanHo).BeginInit();
            grbLocCanHo.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(629, 131);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.ForeColor = Color.Blue;
            btnThemMoi.Image = (Image)resources.GetObject("btnThemMoi.Image");
            btnThemMoi.Location = new Point(490, 131);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(129, 29);
            btnThemMoi.TabIndex = 4;
            btnThemMoi.Text = "+ Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Blue;
            btnTimKiem.Location = new Point(791, 83);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(129, 29);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(490, 83);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(268, 27);
            txtTimKiem.TabIndex = 6;
            // 
            // lblTimKienCanHo
            // 
            lblTimKienCanHo.AutoSize = true;
            lblTimKienCanHo.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblTimKienCanHo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblTimKienCanHo.Location = new Point(490, 57);
            lblTimKienCanHo.Name = "lblTimKienCanHo";
            lblTimKienCanHo.Size = new Size(161, 17);
            lblTimKienCanHo.TabIndex = 7;
            lblTimKienCanHo.Text = "Nhập tên để tìm kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(44, 9);
            label2.Name = "label2";
            label2.Size = new Size(419, 38);
            label2.TabIndex = 7;
            label2.Text = "QUẢN LÝ DANH MỤC CĂN HỘ";
            // 
            // dgvCanHo
            // 
            dgvCanHo.AllowUserToAddRows = false;
            dgvCanHo.AllowUserToDeleteRows = false;
            dgvCanHo.BackgroundColor = Color.White;
            dgvCanHo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCanHo.Dock = DockStyle.Bottom;
            dgvCanHo.Location = new Point(0, 188);
            dgvCanHo.MultiSelect = false;
            dgvCanHo.Name = "dgvCanHo";
            dgvCanHo.ReadOnly = true;
            dgvCanHo.RowHeadersWidth = 51;
            dgvCanHo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCanHo.Size = new Size(981, 432);
            dgvCanHo.TabIndex = 8;
            dgvCanHo.CellClick += dgvCanHo_CellClick;
            dgvCanHo.CellContentClick += dgvCanHo_CellContentClick;
            dgvCanHo.CellDoubleClick += dgvCanHo_CellDoubleClick;
            // 
            // btnCanHoKhongHoatDong
            // 
            btnCanHoKhongHoatDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCanHoKhongHoatDong.Location = new Point(15, 76);
            btnCanHoKhongHoatDong.Name = "btnCanHoKhongHoatDong";
            btnCanHoKhongHoatDong.Size = new Size(229, 27);
            btnCanHoKhongHoatDong.TabIndex = 12;
            btnCanHoKhongHoatDong.Text = "Căn hộ không hoạt động";
            btnCanHoKhongHoatDong.UseVisualStyleBackColor = true;
            btnCanHoKhongHoatDong.Click += btnCanHoKhongHoatDong_Click;
            // 
            // btnCanHoDangHoatDong
            // 
            btnCanHoDangHoatDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCanHoDangHoatDong.Location = new Point(16, 26);
            btnCanHoDangHoatDong.Name = "btnCanHoDangHoatDong";
            btnCanHoDangHoatDong.Size = new Size(233, 29);
            btnCanHoDangHoatDong.TabIndex = 13;
            btnCanHoDangHoatDong.Text = "Căn hộ đang hoạt động";
            btnCanHoDangHoatDong.UseVisualStyleBackColor = true;
            btnCanHoDangHoatDong.Click += btnCanHoDangHoatDong_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.ForeColor = Color.Green;
            btnXuatExcel.Location = new Point(789, 131);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(129, 29);
            btnXuatExcel.TabIndex = 22;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // grbLocCanHo
            // 
            grbLocCanHo.BackColor = Color.Transparent;
            grbLocCanHo.Controls.Add(btnCanHoDangHoatDong);
            grbLocCanHo.Controls.Add(btnCanHoKhongHoatDong);
            grbLocCanHo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            grbLocCanHo.Location = new Point(44, 57);
            grbLocCanHo.Name = "grbLocCanHo";
            grbLocCanHo.Size = new Size(255, 111);
            grbLocCanHo.TabIndex = 23;
            grbLocCanHo.TabStop = false;
            grbLocCanHo.Text = "Lọc";
            grbLocCanHo.Enter += groupBox1_Enter;
            // 
            // frmCanHo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 620);
            Controls.Add(grbLocCanHo);
            Controls.Add(btnXuatExcel);
            Controls.Add(dgvCanHo);
            Controls.Add(label2);
            Controls.Add(lblTimKienCanHo);
            Controls.Add(txtTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnThemMoi);
            Controls.Add(btnTimKiem);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCanHo";
            Text = "frmCanHo";
            Load += frmCanHo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCanHo).EndInit();
            grbLocCanHo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa;
        private Button btnThemMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblTimKienCanHo;
        private Label label2;
        private DataGridView dgvCanHo;
        private Button btnCanHoKhongHoatDong;
        private Button btnCanHoDangHoatDong;
        private Button btnXuatExcel;
        private GroupBox grbLocCanHo;
    }
}