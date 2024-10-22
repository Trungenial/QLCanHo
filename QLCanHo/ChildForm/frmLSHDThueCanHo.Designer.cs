namespace QLCanHo.ChildForm
{
    partial class frmLSHDThueCanHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLSHDThueCanHo));
            btnSearch = new Button();
            txtTuKhoa = new TextBox();
            label2 = new Label();
            dgvLSThueCanHo = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenCanHo = new DataGridViewTextBoxColumn();
            GiaCanHo = new DataGridViewTextBoxColumn();
            DatCoc = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLSThueCanHo).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Blue;
            btnSearch.Location = new Point(348, 133);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTuKhoa.Location = new Point(96, 135);
            txtTuKhoa.Margin = new Padding(4, 5, 4, 5);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(239, 28);
            txtTuKhoa.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 18;
            label2.Text = "Tìm kiếm";
            // 
            // dgvLSThueCanHo
            // 
            dgvLSThueCanHo.AllowUserToAddRows = false;
            dgvLSThueCanHo.AllowUserToDeleteRows = false;
            dgvLSThueCanHo.BackgroundColor = Color.White;
            dgvLSThueCanHo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSThueCanHo.Columns.AddRange(new DataGridViewColumn[] { ID, TenCanHo, GiaCanHo, DatCoc, NgayBatDau, NgayKetThuc });
            dgvLSThueCanHo.Dock = DockStyle.Bottom;
            dgvLSThueCanHo.GridColor = Color.FromArgb(255, 192, 192);
            dgvLSThueCanHo.Location = new Point(0, 198);
            dgvLSThueCanHo.Margin = new Padding(4, 5, 4, 5);
            dgvLSThueCanHo.MultiSelect = false;
            dgvLSThueCanHo.Name = "dgvLSThueCanHo";
            dgvLSThueCanHo.ReadOnly = true;
            dgvLSThueCanHo.RowHeadersWidth = 51;
            dgvLSThueCanHo.Size = new Size(981, 422);
            dgvLSThueCanHo.TabIndex = 17;
            dgvLSThueCanHo.CellContentClick += dgvLSThueCanHo_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenCanHo
            // 
            TenCanHo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenCanHo.DataPropertyName = "TenCanHo";
            TenCanHo.HeaderText = "Tên căn hộ";
            TenCanHo.MinimumWidth = 6;
            TenCanHo.Name = "TenCanHo";
            TenCanHo.ReadOnly = true;
            // 
            // GiaCanHo
            // 
            GiaCanHo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // 
            // DatCoc
            // 
            DatCoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            // 
            // NgayBatDau
            // 
            NgayBatDau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayBatDau.DataPropertyName = "NgayBatDau";
            NgayBatDau.HeaderText = "Ngày thuê";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            NgayBatDau.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayKetThuc.DataPropertyName = "NgayKetThuc";
            NgayKetThuc.HeaderText = "Ngày trả";
            NgayKetThuc.MinimumWidth = 6;
            NgayKetThuc.Name = "NgayKetThuc";
            NgayKetThuc.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(16, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(472, 38);
            label1.TabIndex = 16;
            label1.Text = "LỊCH SỬ HỢP ĐỒNG ĐÃ KẾT THÚC";
            label1.Click += label1_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.ForeColor = Color.Green;
            btnXuatExcel.Location = new Point(839, 135);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(129, 29);
            btnXuatExcel.TabIndex = 21;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // frmLSHDThueCanHo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 620);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnSearch);
            Controls.Add(txtTuKhoa);
            Controls.Add(label2);
            Controls.Add(dgvLSThueCanHo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLSHDThueCanHo";
            Text = "Lịch sửa thuê căn hộ";
            Load += frmLSThueCanHo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLSThueCanHo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtTuKhoa;
        private Label label2;
        private DataGridView dgvLSThueCanHo;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenCanHo;
        private DataGridViewTextBoxColumn GiaCanHo;
        private DataGridViewTextBoxColumn DatCoc;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private Button btnXuatExcel;
    }
}