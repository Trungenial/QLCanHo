namespace QLCanHo.ChildForm
{
    partial class frmLoaiCanHo
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
            GroupBox grbLoaiCanHo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiCanHo));
            txtTenLoaiCanHo = new TextBox();
            label2 = new Label();
            txtDonGia = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            dgvDsLoaiCanHo = new DataGridView();
            btnXoa = new Button();
            btnXuatExcel = new Button();
            grbLoaiCanHo = new GroupBox();
            grbLoaiCanHo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsLoaiCanHo).BeginInit();
            SuspendLayout();
            // 
            // grbLoaiCanHo
            // 
            grbLoaiCanHo.BackColor = Color.Transparent;
            grbLoaiCanHo.Controls.Add(txtTenLoaiCanHo);
            grbLoaiCanHo.Controls.Add(label2);
            grbLoaiCanHo.Controls.Add(txtDonGia);
            grbLoaiCanHo.Controls.Add(label3);
            grbLoaiCanHo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            grbLoaiCanHo.ForeColor = SystemColors.ControlText;
            grbLoaiCanHo.Location = new Point(30, 71);
            grbLoaiCanHo.Name = "grbLoaiCanHo";
            grbLoaiCanHo.Size = new Size(358, 111);
            grbLoaiCanHo.TabIndex = 23;
            grbLoaiCanHo.TabStop = false;
            grbLoaiCanHo.Text = "Thông tin loại căn hộ";
            grbLoaiCanHo.Enter += grbLoaiCanHo_Enter;
            // 
            // txtTenLoaiCanHo
            // 
            txtTenLoaiCanHo.Location = new Point(123, 26);
            txtTenLoaiCanHo.Name = "txtTenLoaiCanHo";
            txtTenLoaiCanHo.Size = new Size(213, 23);
            txtTenLoaiCanHo.TabIndex = 1;
            txtTenLoaiCanHo.TextChanged += txtTenLoaiCanHo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label2.Location = new Point(2, 29);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 0;
            label2.Text = "Tên loại căn hộ";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(121, 77);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(215, 23);
            txtDonGia.TabIndex = 1;
            txtDonGia.Text = "0";
            txtDonGia.TextAlign = HorizontalAlignment.Right;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label3.Location = new Point(0, 80);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 0;
            label3.Text = "Đơn giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ CĂN HỘ";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Blue;
            btnThem.Location = new Point(412, 102);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.Blue;
            btnSua.Location = new Point(597, 97);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(412, 147);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 29);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dgvDsLoaiCanHo
            // 
            dgvDsLoaiCanHo.AllowUserToAddRows = false;
            dgvDsLoaiCanHo.AllowUserToDeleteRows = false;
            dgvDsLoaiCanHo.BackgroundColor = Color.White;
            dgvDsLoaiCanHo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsLoaiCanHo.Dock = DockStyle.Bottom;
            dgvDsLoaiCanHo.Location = new Point(0, 211);
            dgvDsLoaiCanHo.MultiSelect = false;
            dgvDsLoaiCanHo.Name = "dgvDsLoaiCanHo";
            dgvDsLoaiCanHo.ReadOnly = true;
            dgvDsLoaiCanHo.RowHeadersWidth = 51;
            dgvDsLoaiCanHo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDsLoaiCanHo.Size = new Size(981, 409);
            dgvDsLoaiCanHo.TabIndex = 3;
            dgvDsLoaiCanHo.CellClick += dgvDsLoaiCanHo_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(597, 146);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.ForeColor = Color.Green;
            btnXuatExcel.Location = new Point(829, 100);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(129, 76);
            btnXuatExcel.TabIndex = 22;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // frmLoaiCanHo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 620);
            Controls.Add(grbLoaiCanHo);
            Controls.Add(btnXuatExcel);
            Controls.Add(dgvDsLoaiCanHo);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLoaiCanHo";
            Text = "Loại căn hộ";
            FormClosed += frmLoaiPhong_FormClosed;
            Load += frmLoaiCanHo_Load;
            grbLoaiCanHo.ResumeLayout(false);
            grbLoaiCanHo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsLoaiCanHo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDonGia;
        private TextBox txtTenLoaiCanHo;
        private Button btnThem;
        private Button btnSua;
        private Button btnLuu;
        private DataGridView dgvDsLoaiCanHo;
        private Button btnXoa;
        private Button btnXuatExcel;
        private GroupBox grbLoaiCanHo;
    }
}