namespace QLCanHo.ChildForm
{
    partial class frmThueCanHo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThueCanHo));
            label1 = new Label();
            dgvThueCanHo = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenCanHo = new DataGridViewTextBoxColumn();
            GiaCanHo = new DataGridViewTextBoxColumn();
            DatCoc = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            TienVeSinh = new DataGridViewTextBoxColumn();
            TienMang = new DataGridViewTextBoxColumn();
            DonGiaDien = new DataGridViewTextBoxColumn();
            CSD_Cu = new DataGridViewTextBoxColumn();
            DonGiaNuoc = new DataGridViewTextBoxColumn();
            CSN_Cu = new DataGridViewTextBoxColumn();
            no = new DataGridViewTextBoxColumn();
            btnThanhToan = new DataGridViewButtonColumn();
            btnAdd = new Button();
            txtTuKhoa = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            btnXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThueCanHo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(25, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(516, 38);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ CĂN HỘ ĐANG ĐƯỢC THUÊ";
            // 
            // dgvThueCanHo
            // 
            dgvThueCanHo.AllowUserToAddRows = false;
            dgvThueCanHo.AllowUserToDeleteRows = false;
            dgvThueCanHo.BackgroundColor = Color.White;
            dgvThueCanHo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThueCanHo.Columns.AddRange(new DataGridViewColumn[] { ID, TenCanHo, GiaCanHo, DatCoc, NgayBatDau, NgayKetThuc, TienVeSinh, TienMang, DonGiaDien, CSD_Cu, DonGiaNuoc, CSN_Cu, no, btnThanhToan });
            dgvThueCanHo.Dock = DockStyle.Bottom;
            dgvThueCanHo.GridColor = Color.FromArgb(255, 192, 192);
            dgvThueCanHo.Location = new Point(0, 198);
            dgvThueCanHo.Margin = new Padding(4, 5, 4, 5);
            dgvThueCanHo.MultiSelect = false;
            dgvThueCanHo.Name = "dgvThueCanHo";
            dgvThueCanHo.ReadOnly = true;
            dgvThueCanHo.RowHeadersWidth = 51;
            dgvThueCanHo.Size = new Size(981, 422);
            dgvThueCanHo.TabIndex = 2;
            dgvThueCanHo.CellClick += dgvThuePhong_CellClick;
            dgvThueCanHo.CellContentClick += dgvThuePhong_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // TenCanHo
            // 
            TenCanHo.DataPropertyName = "TenCanHo";
            TenCanHo.HeaderText = "Tên căn hộ";
            TenCanHo.MinimumWidth = 6;
            TenCanHo.Name = "TenCanHo";
            TenCanHo.ReadOnly = true;
            TenCanHo.Width = 125;
            // 
            // GiaCanHo
            // 
            GiaCanHo.DataPropertyName = "GiaCanHo";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 10, 0);
            GiaCanHo.DefaultCellStyle = dataGridViewCellStyle1;
            GiaCanHo.HeaderText = "Giá căn hộ";
            GiaCanHo.MinimumWidth = 6;
            GiaCanHo.Name = "GiaCanHo";
            GiaCanHo.ReadOnly = true;
            GiaCanHo.Width = 125;
            // 
            // DatCoc
            // 
            DatCoc.DataPropertyName = "DatCoc";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 10, 0);
            DatCoc.DefaultCellStyle = dataGridViewCellStyle2;
            DatCoc.HeaderText = "Đặt cọc";
            DatCoc.MinimumWidth = 6;
            DatCoc.Name = "DatCoc";
            DatCoc.ReadOnly = true;
            DatCoc.Width = 125;
            // 
            // NgayBatDau
            // 
            NgayBatDau.DataPropertyName = "NgayBatDau";
            NgayBatDau.HeaderText = "Ngày thuê";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            NgayBatDau.ReadOnly = true;
            NgayBatDau.Width = 125;
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.DataPropertyName = "NgayKetThuc";
            NgayKetThuc.HeaderText = "Ngày trả";
            NgayKetThuc.MinimumWidth = 6;
            NgayKetThuc.Name = "NgayKetThuc";
            NgayKetThuc.ReadOnly = true;
            NgayKetThuc.Width = 125;
            // 
            // TienVeSinh
            // 
            TienVeSinh.DataPropertyName = "TienVeSinh";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 10, 0);
            TienVeSinh.DefaultCellStyle = dataGridViewCellStyle3;
            TienVeSinh.HeaderText = "Tiền vệ sinh";
            TienVeSinh.MinimumWidth = 6;
            TienVeSinh.Name = "TienVeSinh";
            TienVeSinh.ReadOnly = true;
            TienVeSinh.Width = 125;
            // 
            // TienMang
            // 
            TienMang.DataPropertyName = "TienMang";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 10, 0);
            TienMang.DefaultCellStyle = dataGridViewCellStyle4;
            TienMang.HeaderText = "Tiền mạng";
            TienMang.MinimumWidth = 6;
            TienMang.Name = "TienMang";
            TienMang.ReadOnly = true;
            TienMang.Width = 125;
            // 
            // DonGiaDien
            // 
            DonGiaDien.DataPropertyName = "DonGiaDien";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 10, 0);
            DonGiaDien.DefaultCellStyle = dataGridViewCellStyle5;
            DonGiaDien.HeaderText = "Đơn giá điện";
            DonGiaDien.MinimumWidth = 6;
            DonGiaDien.Name = "DonGiaDien";
            DonGiaDien.ReadOnly = true;
            DonGiaDien.Width = 125;
            // 
            // CSD_Cu
            // 
            CSD_Cu.DataPropertyName = "CSD_Cu";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 10, 0);
            CSD_Cu.DefaultCellStyle = dataGridViewCellStyle6;
            CSD_Cu.HeaderText = "CSĐ cũ";
            CSD_Cu.MinimumWidth = 6;
            CSD_Cu.Name = "CSD_Cu";
            CSD_Cu.ReadOnly = true;
            CSD_Cu.Width = 125;
            // 
            // DonGiaNuoc
            // 
            DonGiaNuoc.DataPropertyName = "DonGiaNuoc";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.Padding = new Padding(0, 0, 10, 0);
            DonGiaNuoc.DefaultCellStyle = dataGridViewCellStyle7;
            DonGiaNuoc.HeaderText = "Đơn giá nước";
            DonGiaNuoc.MinimumWidth = 6;
            DonGiaNuoc.Name = "DonGiaNuoc";
            DonGiaNuoc.ReadOnly = true;
            DonGiaNuoc.Width = 125;
            // 
            // CSN_Cu
            // 
            CSN_Cu.DataPropertyName = "CSN_Cu";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.Padding = new Padding(0, 0, 10, 0);
            CSN_Cu.DefaultCellStyle = dataGridViewCellStyle8;
            CSN_Cu.HeaderText = "Số nước cũ";
            CSN_Cu.MinimumWidth = 6;
            CSN_Cu.Name = "CSN_Cu";
            CSN_Cu.ReadOnly = true;
            CSN_Cu.Width = 125;
            // 
            // no
            // 
            no.DataPropertyName = "no";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Red;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.Padding = new Padding(0, 0, 10, 0);
            no.DefaultCellStyle = dataGridViewCellStyle9;
            no.HeaderText = "Dư nợ";
            no.MinimumWidth = 6;
            no.Name = "no";
            no.ReadOnly = true;
            no.Width = 125;
            // 
            // btnThanhToan
            // 
            btnThanhToan.HeaderText = "";
            btnThanhToan.MinimumWidth = 6;
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.ReadOnly = true;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseColumnTextForButtonValue = true;
            btnThanhToan.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnAdd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(496, 117);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thuê mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTuKhoa.Location = new Point(111, 120);
            txtTuKhoa.Margin = new Padding(4, 5, 4, 5);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(239, 28);
            txtTuKhoa.TabIndex = 11;
            txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 126);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 10;
            label2.Text = "Tìm kiếm";
            label2.Click += this.label2_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Blue;
            btnSearch.Location = new Point(373, 117);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.ForeColor = Color.Green;
            btnXuatExcel.Location = new Point(619, 117);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(129, 35);
            btnXuatExcel.TabIndex = 23;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // frmThueCanHo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 620);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtTuKhoa);
            Controls.Add(label2);
            Controls.Add(dgvThueCanHo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmThueCanHo";
            Text = "frmThuePhong";
            Load += frmThuePhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThueCanHo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThueCanHo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenCanHo;
        private DataGridViewTextBoxColumn GiaCanHo;
        private DataGridViewTextBoxColumn DatCoc;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn TienVeSinh;
        private DataGridViewTextBoxColumn TienMang;
        private DataGridViewTextBoxColumn DonGiaDien;
        private DataGridViewTextBoxColumn CSD_Cu;
        private DataGridViewTextBoxColumn DonGiaNuoc;
        private DataGridViewTextBoxColumn CSN_Cu;
        private DataGridViewTextBoxColumn no;
        private DataGridViewButtonColumn btnThanhToan;
        private Button btnXuatExcel;
    }
}