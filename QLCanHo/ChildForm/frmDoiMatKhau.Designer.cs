namespace QLCanHo.ChildForm
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            lblEmail = new Label();
            label3 = new Label();
            txtMatKhauMoi = new TextBox();
            txtMatKhauCu = new TextBox();
            txtEmail = new TextBox();
            txtLaiMatKhauMoi = new TextBox();
            btnXaxNhan = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 83);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 4;
            label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 141);
            label2.Name = "label2";
            label2.Size = new Size(161, 31);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu mới:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(42, 25);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 31);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 199);
            label3.Name = "label3";
            label3.Size = new Size(206, 31);
            label3.TabIndex = 2;
            label3.Text = "Nhập lại mật khẩu:";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(261, 145);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(321, 27);
            txtMatKhauMoi.TabIndex = 6;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(261, 87);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(321, 27);
            txtMatKhauCu.TabIndex = 6;
            txtMatKhauCu.TextChanged += txtMatKhauCu_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 27);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtMatKhauCu_TextChanged;
            // 
            // txtLaiMatKhauMoi
            // 
            txtLaiMatKhauMoi.Location = new Point(261, 203);
            txtLaiMatKhauMoi.Name = "txtLaiMatKhauMoi";
            txtLaiMatKhauMoi.PasswordChar = '*';
            txtLaiMatKhauMoi.Size = new Size(321, 27);
            txtLaiMatKhauMoi.TabIndex = 5;
            // 
            // btnXaxNhan
            // 
            btnXaxNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXaxNhan.Location = new Point(357, 265);
            btnXaxNhan.Name = "btnXaxNhan";
            btnXaxNhan.Size = new Size(108, 51);
            btnXaxNhan.TabIndex = 7;
            btnXaxNhan.Text = "Xác nhận";
            btnXaxNhan.UseVisualStyleBackColor = true;
            btnXaxNhan.Click += btnXaxNhan_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(btnXaxNhan);
            panel1.Controls.Add(txtLaiMatKhauMoi);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtMatKhauCu);
            panel1.Controls.Add(txtMatKhauMoi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(181, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 347);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(987, 620);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDoiMatKhau";
            Text = "frmDoiMatKhau";
            Load += frmDoiMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private Panel panel1;
        private Button btnXaxNhan;
        private TextBox txtLaiMatKhauMoi;
        private TextBox txtEmail;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private Label label3;
        private Label lblEmail;
        private Label label2;
        private Label label1;
    }
}