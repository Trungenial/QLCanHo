
namespace QLCanHo
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            grbDangNhap = new GroupBox();
            btnDangNhap = new Button();
            lblDangKy = new Label();
            lblQuenMatKhau = new Label();
            lblChuaCoTaiKhoan = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            grbDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // grbDangNhap
            // 
            grbDangNhap.BackColor = Color.FromArgb(0, 0, 0, 0);
            grbDangNhap.Controls.Add(btnDangNhap);
            grbDangNhap.Controls.Add(lblDangKy);
            grbDangNhap.Controls.Add(lblQuenMatKhau);
            grbDangNhap.Controls.Add(lblChuaCoTaiKhoan);
            grbDangNhap.Controls.Add(txtMatKhau);
            grbDangNhap.Controls.Add(txtTaiKhoan);
            grbDangNhap.Controls.Add(lblMatKhau);
            grbDangNhap.Controls.Add(lblTaiKhoan);
            grbDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDangNhap.Location = new Point(30, 55);
            grbDangNhap.Name = "grbDangNhap";
            grbDangNhap.Size = new Size(308, 409);
            grbDangNhap.TabIndex = 1;
            grbDangNhap.TabStop = false;
            grbDangNhap.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(82, 259);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(145, 44);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lblDangKy
            // 
            lblDangKy.AutoSize = true;
            lblDangKy.Cursor = Cursors.Hand;
            lblDangKy.ForeColor = Color.Navy;
            lblDangKy.Location = new Point(202, 318);
            lblDangKy.Name = "lblDangKy";
            lblDangKy.Size = new Size(90, 28);
            lblDangKy.TabIndex = 5;
            lblDangKy.Text = "Đăng ký";
            lblDangKy.Click += lblDangKy_Click;
            // 
            // lblQuenMatKhau
            // 
            lblQuenMatKhau.AutoSize = true;
            lblQuenMatKhau.Cursor = Cursors.Hand;
            lblQuenMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblQuenMatKhau.Location = new Point(73, 367);
            lblQuenMatKhau.Name = "lblQuenMatKhau";
            lblQuenMatKhau.Size = new Size(166, 28);
            lblQuenMatKhau.TabIndex = 4;
            lblQuenMatKhau.Text = "Quên mật khẩu?";
            lblQuenMatKhau.Click += lblQuenMatKhau_Click;
            // 
            // lblChuaCoTaiKhoan
            // 
            lblChuaCoTaiKhoan.AutoSize = true;
            lblChuaCoTaiKhoan.Location = new Point(13, 318);
            lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            lblChuaCoTaiKhoan.Size = new Size(192, 28);
            lblChuaCoTaiKhoan.TabIndex = 4;
            lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(31, 205);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(247, 34);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(31, 103);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(247, 34);
            txtTaiKhoan.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(21, 157);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(102, 28);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Location = new Point(21, 55);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(140, 28);
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
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 559);
            Controls.Add(grbDangNhap);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDangNhap_Load;
            grbDangNhap.ResumeLayout(false);
            grbDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbDangNhap;
        private TextBox txtTaiKhoan;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
        private TextBox txtMatKhau;
        private Label lblDangKy;
        private Label lblChuaCoTaiKhoan;
        private Button btnDangNhap;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label lblQuenMatKhau;
    }
}
