namespace QLCanHo.ChildForm
{
    partial class frmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMatKhau));
            grbDangNhap = new GroupBox();
            btnLayLaiMatKhau = new Button();
            txtEmail = new TextBox();
            lblKetQua = new Label();
            lblEmail = new Label();
            grbDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // grbDangNhap
            // 
            grbDangNhap.BackColor = Color.FromArgb(0, 0, 0, 0);
            grbDangNhap.Controls.Add(btnLayLaiMatKhau);
            grbDangNhap.Controls.Add(txtEmail);
            grbDangNhap.Controls.Add(lblKetQua);
            grbDangNhap.Controls.Add(lblEmail);
            grbDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDangNhap.Location = new Point(12, 126);
            grbDangNhap.Name = "grbDangNhap";
            grbDangNhap.Size = new Size(350, 286);
            grbDangNhap.TabIndex = 7;
            grbDangNhap.TabStop = false;
            grbDangNhap.Text = "Quên mật khẩu";
            // 
            // btnLayLaiMatKhau
            // 
            btnLayLaiMatKhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLayLaiMatKhau.Location = new Point(27, 192);
            btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            btnLayLaiMatKhau.Size = new Size(298, 44);
            btnLayLaiMatKhau.TabIndex = 6;
            btnLayLaiMatKhau.Text = "Lấy lại mật khẩu";
            btnLayLaiMatKhau.UseVisualStyleBackColor = true;
            btnLayLaiMatKhau.Click += btnLayLaiMatKhau_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 34);
            txtEmail.TabIndex = 2;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(41, 151);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(90, 28);
            lblKetQua.TabIndex = 0;
            lblKetQua.Text = "Kết quả:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(41, 53);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 28);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // frmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(827, 563);
            Controls.Add(grbDangNhap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmQuenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuenMatKhau";
            grbDangNhap.ResumeLayout(false);
            grbDangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbDangNhap;
        private Button btnLayLaiMatKhau;
        private TextBox txtEmail;
        private Label lblKetQua;
        private Label lblEmail;
    }
}