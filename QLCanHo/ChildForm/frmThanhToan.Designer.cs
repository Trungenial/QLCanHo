namespace QLCanHo.ChildForm
{
    partial class frmThanhToan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            txtThanhToan = new TextBox();
            label2 = new Label();
            btnHuy = new Button();
            btnThanhToanGiaHan = new Button();
            label1 = new Label();
            grbContent = new GroupBox();
            label6 = new Label();
            lblTitle = new Label();
            btnThanhToanTraCanHo = new Button();
            lblConLai = new Label();
            lblTienDien = new Label();
            lblTongTienCanThanhToan = new Label();
            lblSoDuNo = new Label();
            lblTongTienThang = new Label();
            lblTienMang = new Label();
            lblTienVeSinh = new Label();
            lblTienNuoc = new Label();
            lblTienPhong = new Label();
            label4 = new Label();
            lblCanHo = new Label();
            label17 = new Label();
            label7 = new Label();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            grbContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtThanhToan
            // 
            txtThanhToan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThanhToan.Location = new Point(195, 349);
            txtThanhToan.Margin = new Padding(4, 5, 4, 5);
            txtThanhToan.Name = "txtThanhToan";
            txtThanhToan.Size = new Size(167, 23);
            txtThanhToan.TabIndex = 2;
            txtThanhToan.TextAlign = HorizontalAlignment.Right;
            txtThanhToan.KeyPress += txtThanhToan_KeyPress;
            txtThanhToan.KeyUp += txtThanhToan_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(49, 349);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 7;
            label2.Text = "Thanh toán";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(450, 477);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(59, 35);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThanhToanGiaHan
            // 
            btnThanhToanGiaHan.BackColor = Color.White;
            btnThanhToanGiaHan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToanGiaHan.ForeColor = Color.Black;
            btnThanhToanGiaHan.Location = new Point(210, 432);
            btnThanhToanGiaHan.Margin = new Padding(4, 5, 4, 5);
            btnThanhToanGiaHan.Name = "btnThanhToanGiaHan";
            btnThanhToanGiaHan.Size = new Size(251, 35);
            btnThanhToanGiaHan.TabIndex = 5;
            btnThanhToanGiaHan.Text = "Thanh toán và gia hạn";
            btnThanhToanGiaHan.UseVisualStyleBackColor = false;
            btnThanhToanGiaHan.Click += btnThanhToanGiaHan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 1;
            label1.Text = "Tiền căn hộ:";
            // 
            // grbContent
            // 
            grbContent.BackColor = Color.FromArgb(0, 0, 0, 0);
            grbContent.Controls.Add(label6);
            grbContent.Controls.Add(lblTitle);
            grbContent.Controls.Add(btnThanhToanTraCanHo);
            grbContent.Controls.Add(txtThanhToan);
            grbContent.Controls.Add(label2);
            grbContent.Controls.Add(btnHuy);
            grbContent.Controls.Add(btnThanhToanGiaHan);
            grbContent.Controls.Add(lblConLai);
            grbContent.Controls.Add(lblTienDien);
            grbContent.Controls.Add(lblTongTienCanThanhToan);
            grbContent.Controls.Add(lblSoDuNo);
            grbContent.Controls.Add(lblTongTienThang);
            grbContent.Controls.Add(lblTienMang);
            grbContent.Controls.Add(lblTienVeSinh);
            grbContent.Controls.Add(lblTienNuoc);
            grbContent.Controls.Add(lblTienPhong);
            grbContent.Controls.Add(label4);
            grbContent.Controls.Add(lblCanHo);
            grbContent.Controls.Add(label17);
            grbContent.Controls.Add(label7);
            grbContent.Controls.Add(label15);
            grbContent.Controls.Add(label13);
            grbContent.Controls.Add(label11);
            grbContent.Controls.Add(label9);
            grbContent.Controls.Add(label5);
            grbContent.Controls.Add(label3);
            grbContent.Controls.Add(label1);
            grbContent.Dock = DockStyle.Fill;
            grbContent.Location = new Point(0, 0);
            grbContent.Margin = new Padding(4, 5, 4, 5);
            grbContent.Name = "grbContent";
            grbContent.Padding = new Padding(4, 5, 4, 5);
            grbContent.Size = new Size(959, 595);
            grbContent.TabIndex = 16;
            grbContent.TabStop = false;
            grbContent.Enter += grbContent_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 351);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 9;
            label6.Text = "VNĐ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(367, 18);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(203, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "THANH TOÁN";
            // 
            // btnThanhToanTraCanHo
            // 
            btnThanhToanTraCanHo.BackColor = Color.White;
            btnThanhToanTraCanHo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToanTraCanHo.ForeColor = Color.Black;
            btnThanhToanTraCanHo.Location = new Point(480, 432);
            btnThanhToanTraCanHo.Margin = new Padding(4, 5, 4, 5);
            btnThanhToanTraCanHo.Name = "btnThanhToanTraCanHo";
            btnThanhToanTraCanHo.Size = new Size(257, 35);
            btnThanhToanTraCanHo.TabIndex = 8;
            btnThanhToanTraCanHo.Text = "Thanh toán và trả căn hộ";
            btnThanhToanTraCanHo.UseVisualStyleBackColor = false;
            btnThanhToanTraCanHo.Click += btnThanhToanTraPhong_Click;
            // 
            // lblConLai
            // 
            lblConLai.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConLai.ForeColor = Color.Black;
            lblConLai.Location = new Point(696, 349);
            lblConLai.Margin = new Padding(4, 0, 4, 0);
            lblConLai.Name = "lblConLai";
            lblConLai.Size = new Size(172, 20);
            lblConLai.TabIndex = 1;
            lblConLai.Text = "0";
            lblConLai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTienDien
            // 
            lblTienDien.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienDien.ForeColor = Color.Black;
            lblTienDien.Location = new Point(696, 115);
            lblTienDien.Margin = new Padding(4, 0, 4, 0);
            lblTienDien.Name = "lblTienDien";
            lblTienDien.Size = new Size(172, 20);
            lblTienDien.TabIndex = 1;
            lblTienDien.Text = "0";
            lblTienDien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTongTienCanThanhToan
            // 
            lblTongTienCanThanhToan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienCanThanhToan.ForeColor = Color.Black;
            lblTongTienCanThanhToan.Location = new Point(696, 258);
            lblTongTienCanThanhToan.Margin = new Padding(4, 0, 4, 0);
            lblTongTienCanThanhToan.Name = "lblTongTienCanThanhToan";
            lblTongTienCanThanhToan.Size = new Size(172, 20);
            lblTongTienCanThanhToan.TabIndex = 1;
            lblTongTienCanThanhToan.Text = "0";
            lblTongTienCanThanhToan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSoDuNo
            // 
            lblSoDuNo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoDuNo.ForeColor = Color.Black;
            lblSoDuNo.Location = new Point(215, 258);
            lblSoDuNo.Margin = new Padding(4, 0, 4, 0);
            lblSoDuNo.Name = "lblSoDuNo";
            lblSoDuNo.Size = new Size(157, 20);
            lblSoDuNo.TabIndex = 1;
            lblSoDuNo.Text = "0";
            lblSoDuNo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTongTienThang
            // 
            lblTongTienThang.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienThang.ForeColor = Color.Black;
            lblTongTienThang.Location = new Point(696, 211);
            lblTongTienThang.Margin = new Padding(4, 0, 4, 0);
            lblTongTienThang.Name = "lblTongTienThang";
            lblTongTienThang.Size = new Size(172, 20);
            lblTongTienThang.TabIndex = 1;
            lblTongTienThang.Text = "0";
            lblTongTienThang.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTienMang
            // 
            lblTienMang.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienMang.ForeColor = Color.Black;
            lblTienMang.Location = new Point(215, 211);
            lblTienMang.Margin = new Padding(4, 0, 4, 0);
            lblTienMang.Name = "lblTienMang";
            lblTienMang.Size = new Size(157, 20);
            lblTienMang.TabIndex = 1;
            lblTienMang.Text = "0";
            lblTienMang.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTienVeSinh
            // 
            lblTienVeSinh.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienVeSinh.ForeColor = Color.Black;
            lblTienVeSinh.Location = new Point(696, 163);
            lblTienVeSinh.Margin = new Padding(4, 0, 4, 0);
            lblTienVeSinh.Name = "lblTienVeSinh";
            lblTienVeSinh.Size = new Size(172, 20);
            lblTienVeSinh.TabIndex = 1;
            lblTienVeSinh.Text = "0";
            lblTienVeSinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTienNuoc
            // 
            lblTienNuoc.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienNuoc.ForeColor = Color.Black;
            lblTienNuoc.Location = new Point(215, 163);
            lblTienNuoc.Margin = new Padding(4, 0, 4, 0);
            lblTienNuoc.Name = "lblTienNuoc";
            lblTienNuoc.Size = new Size(157, 20);
            lblTienNuoc.TabIndex = 1;
            lblTienNuoc.Text = "0";
            lblTienNuoc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTienPhong
            // 
            lblTienPhong.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienPhong.ForeColor = Color.Black;
            lblTienPhong.Location = new Point(215, 115);
            lblTienPhong.Margin = new Padding(4, 0, 4, 0);
            lblTienPhong.Name = "lblTienPhong";
            lblTienPhong.Size = new Size(157, 20);
            lblTienPhong.TabIndex = 1;
            lblTienPhong.Text = "0";
            lblTienPhong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(488, 354);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 1;
            label4.Text = "Còn lại";
            // 
            // lblCanHo
            // 
            lblCanHo.AutoSize = true;
            lblCanHo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCanHo.ForeColor = Color.Black;
            lblCanHo.Location = new Point(282, 72);
            lblCanHo.Margin = new Padding(4, 0, 4, 0);
            lblCanHo.Name = "lblCanHo";
            lblCanHo.Size = new Size(90, 17);
            lblCanHo.TabIndex = 1;
            lblCanHo.Text = "Tên căn hộ";
            lblCanHo.Click += lblPhong_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(483, 258);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(196, 17);
            label17.TabIndex = 1;
            label17.Text = "Tổng tiền cần thanh toán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(483, 115);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 1;
            label7.Text = "Tiền điện:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(52, 258);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(127, 17);
            label15.TabIndex = 1;
            label15.Text = "Số nợ còn thiếu:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(483, 211);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(154, 17);
            label13.TabIndex = 1;
            label13.Text = "Tổng tiền phát sinh:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(52, 211);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(89, 17);
            label11.TabIndex = 1;
            label11.Text = "Tiền mạng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(483, 163);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(102, 17);
            label9.TabIndex = 1;
            label9.Text = "Tiền vệ sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(52, 163);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 17);
            label5.TabIndex = 1;
            label5.Text = "Tiền nước:";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 1;
            label3.Text = "Tên Căn hộ:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 595);
            Controls.Add(grbContent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmThanhToan";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh toán";
            Load += frmThanhToan_Load;
            grbContent.ResumeLayout(false);
            grbContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToanGiaHan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConLai;
        private System.Windows.Forms.Label lblCanHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTienDien;
        private System.Windows.Forms.Label lblTongTienCanThanhToan;
        private System.Windows.Forms.Label lblSoDuNo;
        private System.Windows.Forms.Label lblTongTienThang;
        private System.Windows.Forms.Label lblTienMang;
        private System.Windows.Forms.Label lblTienVeSinh;
        private System.Windows.Forms.Label lblTienNuoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToanTraCanHo;
        private Label lblTitle;
        private ErrorProvider errorProvider1;
        private Label label6;
    }
}