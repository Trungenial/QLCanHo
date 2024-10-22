namespace QLCanHo.ChildForm
{
    partial class frmHopDongThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDongThue));
            grbContent = new GroupBox();
            dtpNgayTra = new DateTimePicker();
            dtpNgayThue = new DateTimePicker();
            lblTitle = new Label();
            dgvKhachHang = new DataGridView();
            txtTen = new TextBox();
            txtTenDem = new TextBox();
            label2 = new Label();
            txtHKTT = new TextBox();
            txtQueQuan = new TextBox();
            label7 = new Label();
            txtDienThoai = new TextBox();
            label6 = new Label();
            txtCMND = new TextBox();
            label8 = new Label();
            txtHo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnThemKH = new Button();
            label15 = new Label();
            label13 = new Label();
            label14 = new Label();
            label12 = new Label();
            txtTienMang = new TextBox();
            txtCSNuoc = new TextBox();
            txtTienVeSinh = new TextBox();
            txtCSDien = new TextBox();
            label5 = new Label();
            txtDatCoc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnHuy = new Button();
            btnXacNhan = new Button();
            label1 = new Label();
            cbbPhong = new ComboBox();
            pblBottom = new Panel();
            grbContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // grbContent
            // 
            grbContent.BackColor = Color.FromArgb(0, 0, 0, 0);
            grbContent.Controls.Add(dtpNgayTra);
            grbContent.Controls.Add(dtpNgayThue);
            grbContent.Controls.Add(lblTitle);
            grbContent.Controls.Add(dgvKhachHang);
            grbContent.Controls.Add(txtTen);
            grbContent.Controls.Add(txtTenDem);
            grbContent.Controls.Add(label2);
            grbContent.Controls.Add(txtHKTT);
            grbContent.Controls.Add(txtQueQuan);
            grbContent.Controls.Add(label7);
            grbContent.Controls.Add(txtDienThoai);
            grbContent.Controls.Add(label6);
            grbContent.Controls.Add(txtCMND);
            grbContent.Controls.Add(label8);
            grbContent.Controls.Add(txtHo);
            grbContent.Controls.Add(label9);
            grbContent.Controls.Add(label10);
            grbContent.Controls.Add(label11);
            grbContent.Controls.Add(btnThemKH);
            grbContent.Controls.Add(label15);
            grbContent.Controls.Add(label13);
            grbContent.Controls.Add(label14);
            grbContent.Controls.Add(label12);
            grbContent.Controls.Add(txtTienMang);
            grbContent.Controls.Add(txtCSNuoc);
            grbContent.Controls.Add(txtTienVeSinh);
            grbContent.Controls.Add(txtCSDien);
            grbContent.Controls.Add(label5);
            grbContent.Controls.Add(txtDatCoc);
            grbContent.Controls.Add(label4);
            grbContent.Controls.Add(label3);
            grbContent.Controls.Add(btnHuy);
            grbContent.Controls.Add(btnXacNhan);
            grbContent.Controls.Add(label1);
            grbContent.Controls.Add(cbbPhong);
            grbContent.Dock = DockStyle.Bottom;
            grbContent.Location = new Point(0, 0);
            grbContent.Margin = new Padding(4, 5, 4, 5);
            grbContent.Name = "grbContent";
            grbContent.Padding = new Padding(4, 5, 4, 5);
            grbContent.Size = new Size(917, 807);
            grbContent.TabIndex = 11;
            grbContent.TabStop = false;
            grbContent.Enter += grbContent_Enter;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(650, 115);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(219, 27);
            dtpNgayTra.TabIndex = 55;
            dtpNgayTra.Value = new DateTime(2024, 5, 4, 0, 0, 0, 0);
            dtpNgayTra.ValueChanged += this.dtpNgayTra_ValueChanged;
            // 
            // dtpNgayThue
            // 
            dtpNgayThue.CustomFormat = "dd/MM/yyyy";
            dtpNgayThue.Format = DateTimePickerFormat.Custom;
            dtpNgayThue.Location = new Point(216, 115);
            dtpNgayThue.Name = "dtpNgayThue";
            dtpNgayThue.Size = new Size(253, 27);
            dtpNgayThue.TabIndex = 55;
            dtpNgayThue.ValueChanged += this.dtpNgayThue_ValueChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(328, 40);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "KHỞI TẠO HỢP ĐỒNG";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(54, 532);
            dgvKhachHang.Margin = new Padding(4, 5, 4, 5);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(815, 200);
            dgvKhachHang.TabIndex = 54;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(216, 360);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(253, 23);
            txtTen.TabIndex = 11;
            // 
            // txtTenDem
            // 
            txtTenDem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenDem.Location = new Point(216, 320);
            txtTenDem.Margin = new Padding(4, 5, 4, 5);
            txtTenDem.Name = "txtTenDem";
            txtTenDem.Size = new Size(253, 23);
            txtTenDem.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(54, 358);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 46;
            label2.Text = "Tên:";
            // 
            // txtHKTT
            // 
            txtHKTT.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHKTT.Location = new Point(650, 442);
            txtHKTT.Margin = new Padding(4, 5, 4, 5);
            txtHKTT.Name = "txtHKTT";
            txtHKTT.Size = new Size(221, 23);
            txtHKTT.TabIndex = 15;
            txtHKTT.TextChanged += txtHKTT_TextChanged;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQueQuan.Location = new Point(216, 440);
            txtQueQuan.Margin = new Padding(4, 5, 4, 5);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(253, 23);
            txtQueQuan.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(480, 442);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 17);
            label7.TabIndex = 48;
            label7.Text = "Hộ khẩu thường trú";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDienThoai.Location = new Point(652, 403);
            txtDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(219, 23);
            txtDienThoai.TabIndex = 13;
            txtDienThoai.TextChanged += txtDienThoai_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 438);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 17);
            label6.TabIndex = 49;
            label6.Text = "Quê quán:";
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCMND.Location = new Point(216, 400);
            txtCMND.Margin = new Padding(4, 5, 4, 5);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(253, 23);
            txtCMND.TabIndex = 12;
            txtCMND.TextChanged += this.txtCMND_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(477, 403);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 17);
            label8.TabIndex = 50;
            label8.Text = "Điện thoại:";
            // 
            // txtHo
            // 
            txtHo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHo.Location = new Point(216, 280);
            txtHo.Margin = new Padding(4, 5, 4, 5);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(253, 23);
            txtHo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(54, 398);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 17);
            label9.TabIndex = 51;
            label9.Text = "CMND/CCCD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(54, 318);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 17);
            label10.TabIndex = 52;
            label10.Text = "Tên đệm:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(54, 278);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(33, 17);
            label11.TabIndex = 53;
            label11.Text = "Họ:";
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = Color.White;
            btnThemKH.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKH.ForeColor = Color.Black;
            btnThemKH.Location = new Point(216, 480);
            btnThemKH.Margin = new Padding(4, 5, 4, 5);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(253, 35);
            btnThemKH.TabIndex = 16;
            btnThemKH.Text = "Thêm khách hàng vào hợp đồng";
            btnThemKH.UseVisualStyleBackColor = false;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(482, 241);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(106, 17);
            label15.TabIndex = 16;
            label15.Text = "Tiền Internet:";
            label15.Click += label15_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(480, 197);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(162, 17);
            label13.TabIndex = 16;
            label13.Text = "Chỉ số nước ban đầu:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(54, 238);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(102, 17);
            label14.TabIndex = 16;
            label14.Text = "Tiền vệ sinh:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(54, 198);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(158, 17);
            label12.TabIndex = 16;
            label12.Text = "Chỉ số điện ban đầu:";
            // 
            // txtTienMang
            // 
            txtTienMang.Location = new Point(650, 236);
            txtTienMang.Margin = new Padding(4, 5, 4, 5);
            txtTienMang.Name = "txtTienMang";
            txtTienMang.Size = new Size(219, 27);
            txtTienMang.TabIndex = 8;
            txtTienMang.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCSNuoc
            // 
            txtCSNuoc.Location = new Point(650, 192);
            txtCSNuoc.Margin = new Padding(4, 5, 4, 5);
            txtCSNuoc.Name = "txtCSNuoc";
            txtCSNuoc.Size = new Size(219, 27);
            txtCSNuoc.TabIndex = 6;
            txtCSNuoc.TextAlign = HorizontalAlignment.Right;
            txtCSNuoc.TextChanged += txtCSNuoc_TextChanged;
            // 
            // txtTienVeSinh
            // 
            txtTienVeSinh.Location = new Point(216, 236);
            txtTienVeSinh.Margin = new Padding(4, 5, 4, 5);
            txtTienVeSinh.Name = "txtTienVeSinh";
            txtTienVeSinh.Size = new Size(253, 27);
            txtTienVeSinh.TabIndex = 7;
            txtTienVeSinh.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCSDien
            // 
            txtCSDien.Location = new Point(216, 192);
            txtCSDien.Margin = new Padding(4, 5, 4, 5);
            txtCSDien.Name = "txtCSDien";
            txtCSDien.Size = new Size(253, 27);
            txtCSDien.TabIndex = 5;
            txtCSDien.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(482, 122);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 17);
            label5.TabIndex = 7;
            label5.Text = "Ngày kết thúc:";
            label5.Click += this.label5_Click;
            // 
            // txtDatCoc
            // 
            txtDatCoc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDatCoc.Location = new Point(650, 486);
            txtDatCoc.Margin = new Padding(4, 5, 4, 5);
            txtDatCoc.Name = "txtDatCoc";
            txtDatCoc.Size = new Size(221, 23);
            txtDatCoc.TabIndex = 3;
            txtDatCoc.TextAlign = HorizontalAlignment.Right;
            txtDatCoc.KeyPress += txtDatCoc_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(54, 118);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 17);
            label4.TabIndex = 7;
            label4.Text = "Ngày bắt đầu:";
            label4.Click += this.label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(482, 495);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 7;
            label3.Text = "Đặt cọc:";
            label3.Click += this.label3_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Azure;
            btnHuy.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(479, 752);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(129, 29);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Azure;
            btnXacNhan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.Blue;
            btnXacNhan.Location = new Point(318, 749);
            btnXacNhan.Margin = new Padding(4, 5, 4, 5);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(129, 29);
            btnXacNhan.TabIndex = 17;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(54, 158);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 17);
            label1.TabIndex = 1;
            label1.Text = "Căn hộ sẵn sàng:";
            label1.Click += this.label1_Click;
            // 
            // cbbPhong
            // 
            cbbPhong.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbbPhong.FormattingEnabled = true;
            cbbPhong.Location = new Point(216, 150);
            cbbPhong.Margin = new Padding(4, 5, 4, 5);
            cbbPhong.Name = "cbbPhong";
            cbbPhong.Size = new Size(653, 25);
            cbbPhong.TabIndex = 4;
            // 
            // pblBottom
            // 
            pblBottom.Dock = DockStyle.Bottom;
            pblBottom.Location = new Point(0, 807);
            pblBottom.Margin = new Padding(4, 5, 4, 5);
            pblBottom.Name = "pblBottom";
            pblBottom.Size = new Size(917, 15);
            pblBottom.TabIndex = 10;
            // 
            // frmHopDongThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 822);
            Controls.Add(grbContent);
            Controls.Add(pblBottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHopDongThue";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hợp đồng thuê";
            Load += frmThue_Load;
            grbContent.ResumeLayout(false);
            grbContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.TextBox txtDatCoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pblBottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTienMang;
        private System.Windows.Forms.TextBox txtCSNuoc;
        private System.Windows.Forms.TextBox txtTienVeSinh;
        private System.Windows.Forms.TextBox txtCSDien;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTenDem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHKTT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemKH;
        private DateTimePicker dtpNgayTra;
        private DateTimePicker dtpNgayThue;
    }
}