namespace QLCanHo.ChildForm
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            grbDangKy = new GroupBox();
            btnDangKy = new Button();
            lblDangNhap = new Label();
            lblChuaCoTaiKhoan = new Label();
            txtEmail = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            txtMatKhau = new TextBox();
            lblEmail = new Label();
            txtTaiKhoan = new TextBox();
            lblNhapLaiMatKhau = new Label();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            grbDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // grbDangKy
            // 
            grbDangKy.BackColor = Color.FromArgb(0, 0, 0, 0);
            grbDangKy.Controls.Add(btnDangKy);
            grbDangKy.Controls.Add(lblDangNhap);
            grbDangKy.Controls.Add(lblChuaCoTaiKhoan);
            grbDangKy.Controls.Add(txtEmail);
            grbDangKy.Controls.Add(txtNhapLaiMatKhau);
            grbDangKy.Controls.Add(txtMatKhau);
            grbDangKy.Controls.Add(lblEmail);
            grbDangKy.Controls.Add(txtTaiKhoan);
            grbDangKy.Controls.Add(lblNhapLaiMatKhau);
            grbDangKy.Controls.Add(lblMatKhau);
            grbDangKy.Controls.Add(lblTaiKhoan);
            grbDangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDangKy.Location = new Point(37, 38);
            grbDangKy.Name = "grbDangKy";
            grbDangKy.Size = new Size(282, 484);
            grbDangKy.TabIndex = 4;
            grbDangKy.TabStop = false;
            grbDangKy.Text = "Đăng ký";
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.Location = new Point(83, 405);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(110, 35);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Cursor = Cursors.Hand;
            lblDangNhap.ForeColor = Color.White;
            lblDangNhap.Location = new Point(157, 443);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(98, 23);
            lblDangNhap.TabIndex = 5;
            lblDangNhap.Text = "Đăng nhập";
            lblDangNhap.Click += lblDangNhap_Click;
            // 
            // lblChuaCoTaiKhoan
            // 
            lblChuaCoTaiKhoan.AutoSize = true;
            lblChuaCoTaiKhoan.Location = new Point(9, 443);
            lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            lblChuaCoTaiKhoan.Size = new Size(142, 23);
            lblChuaCoTaiKhoan.TabIndex = 4;
            lblChuaCoTaiKhoan.Text = "Đã có tài khoản?";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 355);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '*';
            txtEmail.Size = new Size(212, 30);
            txtEmail.TabIndex = 3;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(35, 266);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.PasswordChar = '*';
            txtNhapLaiMatKhau.Size = new Size(212, 30);
            txtNhapLaiMatKhau.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(35, 177);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(212, 30);
            txtMatKhau.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 314);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(35, 88);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(212, 30);
            txtTaiKhoan.TabIndex = 2;
            // 
            // lblNhapLaiMatKhau
            // 
            lblNhapLaiMatKhau.AutoSize = true;
            lblNhapLaiMatKhau.Location = new Point(35, 225);
            lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            lblNhapLaiMatKhau.Size = new Size(158, 23);
            lblNhapLaiMatKhau.TabIndex = 1;
            lblNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(35, 136);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Location = new Point(34, 47);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(117, 23);
            lblTaiKhoan.TabIndex = 0;
            lblTaiKhoan.Text = "Tên tài khoản";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 559);
            Controls.Add(grbDangKy);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDangKy_Load;
            grbDangKy.ResumeLayout(false);
            grbDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbDangKy;
        private Button btnDangKy;
        private Label lblDangNhap;
        private Label lblChuaCoTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
        private TextBox txtNhapLaiMatKhau;
        private Label lblNhapLaiMatKhau;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private TextBox txtEmail;
        private Label lblEmail;
        private ErrorProvider errorProvider4;
    }
}