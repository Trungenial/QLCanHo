namespace QLCanHo.ChildForm
{
    partial class frmUpdateCanHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCanHo));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ckbHoatDong = new CheckBox();
            btnXacNhan = new Button();
            btnHuy = new Button();
            cbbLoaiCanHo = new ComboBox();
            txtTenCanHo = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Location = new Point(100, 88);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại căn hộ";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Location = new Point(100, 126);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên căn hộ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Location = new Point(100, 168);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "Trạng thái";
            // 
            // ckbHoatDong
            // 
            ckbHoatDong.AutoSize = true;
            ckbHoatDong.BackColor = Color.FromArgb(0, 0, 0, 0);
            ckbHoatDong.Checked = true;
            ckbHoatDong.CheckState = CheckState.Checked;
            ckbHoatDong.Location = new Point(197, 168);
            ckbHoatDong.Name = "ckbHoatDong";
            ckbHoatDong.Size = new Size(103, 24);
            ckbHoatDong.TabIndex = 2;
            ckbHoatDong.Text = "Hoạt động";
            ckbHoatDong.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(199, 201);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(317, 201);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // cbbLoaiCanHo
            // 
            cbbLoaiCanHo.FormattingEnabled = true;
            cbbLoaiCanHo.Location = new Point(197, 85);
            cbbLoaiCanHo.Name = "cbbLoaiCanHo";
            cbbLoaiCanHo.Size = new Size(334, 28);
            cbbLoaiCanHo.TabIndex = 4;
            // 
            // txtTenCanHo
            // 
            txtTenCanHo.Location = new Point(201, 128);
            txtTenCanHo.Name = "txtTenCanHo";
            txtTenCanHo.Size = new Size(330, 27);
            txtTenCanHo.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(134, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 41);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Cập nhật thông tin căn hộ";
            lblTitle.Click += lblTitle_Click;
            // 
            // frmUpdateCanHo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(631, 308);
            Controls.Add(lblTitle);
            Controls.Add(txtTenCanHo);
            Controls.Add(cbbLoaiCanHo);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(ckbHoatDong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUpdateCanHo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCanHo";
            FormClosed += frmXuLyCanHo_FormClosed;
            Load += frmXuLyCanHo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox ckbHoatDong;
        private Button btnXacNhan;
        private Button btnHuy;
        private ComboBox cbbLoaiCanHo;
        private TextBox txtTenCanHo;
        private Label lblTitle;
    }
}