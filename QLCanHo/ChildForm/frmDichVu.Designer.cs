namespace QLCanHo.ChildForm
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            btnXoa = new Button();
            btnThemMoi = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            lblTim = new Label();
            dgvDV = new DataGridView();
            txtTenDV = new TextBox();
            label3 = new Label();
            btnCapNhat = new Button();
            btnXuatExcel = new Button();
            grbDanhMucDichVu = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDV).BeginInit();
            grbDanhMucDichVu.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.White;
            btnXoa.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(312, 80);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.BackColor = Color.White;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.ForeColor = Color.Blue;
            btnThemMoi.Location = new Point(28, 80);
            btnThemMoi.Margin = new Padding(4, 5, 4, 5);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(129, 29);
            btnThemMoi.TabIndex = 11;
            btnThemMoi.Text = "+ Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.White;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.Blue;
            btnTimKiem.Location = new Point(818, 83);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(129, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Location = new Point(571, 85);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(218, 27);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(33, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 38);
            label2.TabIndex = 7;
            label2.Text = "DANH MỤC DỊCH VỤ";
            // 
            // lblTim
            // 
            lblTim.AutoSize = true;
            lblTim.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblTim.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblTim.ForeColor = Color.Black;
            lblTim.Location = new Point(570, 63);
            lblTim.Margin = new Padding(4, 0, 4, 0);
            lblTim.Name = "lblTim";
            lblTim.Size = new Size(218, 17);
            lblTim.TabIndex = 8;
            lblTim.Text = "Nhập tên dịch vụ để tìm kiếm";
            lblTim.Click += lblTim_Click;
            // 
            // dgvDV
            // 
            dgvDV.AllowUserToAddRows = false;
            dgvDV.AllowUserToDeleteRows = false;
            dgvDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDV.BackgroundColor = Color.White;
            dgvDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDV.GridColor = Color.Gray;
            dgvDV.Location = new Point(0, 190);
            dgvDV.Margin = new Padding(4, 5, 4, 5);
            dgvDV.MultiSelect = false;
            dgvDV.Name = "dgvDV";
            dgvDV.ReadOnly = true;
            dgvDV.RowHeadersWidth = 51;
            dgvDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDV.Size = new Size(981, 430);
            dgvDV.TabIndex = 6;
            dgvDV.CellClick += dgvDV_CellClick;
            // 
            // txtTenDV
            // 
            txtTenDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTenDV.Location = new Point(170, 28);
            txtTenDV.Margin = new Padding(4, 5, 4, 5);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(271, 23);
            txtTenDV.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(41, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 17);
            label3.TabIndex = 8;
            label3.Text = "Tên dịch vụ ";
            label3.Click += label3_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCapNhat.BackColor = Color.White;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.Blue;
            btnCapNhat.Location = new Point(170, 80);
            btnCapNhat.Margin = new Padding(4, 5, 4, 5);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(129, 29);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.ForeColor = Color.Green;
            btnXuatExcel.Location = new Point(818, 137);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(129, 29);
            btnXuatExcel.TabIndex = 23;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // grbDanhMucDichVu
            // 
            grbDanhMucDichVu.BackColor = Color.Transparent;
            grbDanhMucDichVu.Controls.Add(txtTenDV);
            grbDanhMucDichVu.Controls.Add(label3);
            grbDanhMucDichVu.Controls.Add(btnCapNhat);
            grbDanhMucDichVu.Controls.Add(btnXoa);
            grbDanhMucDichVu.Controls.Add(btnThemMoi);
            grbDanhMucDichVu.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            grbDanhMucDichVu.ForeColor = Color.Black;
            grbDanhMucDichVu.ImeMode = ImeMode.On;
            grbDanhMucDichVu.Location = new Point(33, 57);
            grbDanhMucDichVu.Name = "grbDanhMucDichVu";
            grbDanhMucDichVu.Size = new Size(492, 125);
            grbDanhMucDichVu.TabIndex = 24;
            grbDanhMucDichVu.TabStop = false;
            grbDanhMucDichVu.Text = "Thao tác với danh mục dịch vụ";
            grbDanhMucDichVu.Enter += grbDanhMucDichVu_Enter;
            // 
            // frmDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(981, 620);
            Controls.Add(grbDanhMucDichVu);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(lblTim);
            Controls.Add(dgvDV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDichVu";
            Text = "frmDichVu";
            Load += frmDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDV).EndInit();
            grbDanhMucDichVu.ResumeLayout(false);
            grbDanhMucDichVu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhat;
        private Button btnXuatExcel;
        private GroupBox grbDanhMucDichVu;
    }
}