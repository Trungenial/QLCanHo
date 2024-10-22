namespace QLCanHo.ChildForm
{
    partial class frmUpdateDienNuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDienNuoc));
            label1 = new Label();
            label2 = new Label();
            txtDien = new TextBox();
            txtNuoc = new TextBox();
            btnXacNhan = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(308, 146);
            label1.Name = "label1";
            label1.Size = new Size(151, 31);
            label1.TabIndex = 0;
            label1.Text = "Giá điện mới";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(308, 228);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 1;
            label2.Text = "Giá nước mới";
            label2.Click += label2_Click;
            // 
            // txtDien
            // 
            txtDien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDien.Location = new Point(517, 138);
            txtDien.Name = "txtDien";
            txtDien.Size = new Size(185, 43);
            txtDien.TabIndex = 2;
            txtDien.TextChanged += txtDien_TextChanged;
            // 
            // txtNuoc
            // 
            txtNuoc.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNuoc.Location = new Point(517, 220);
            txtNuoc.Name = "txtNuoc";
            txtNuoc.Size = new Size(185, 43);
            txtNuoc.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.Location = new Point(553, 288);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(119, 40);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(309, 62);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(393, 59);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "CẬP NHẬT GIÁ ĐIỆN NƯỚC";
            lblTitle.Click += lblTitle_Click;
            // 
            // frmUpdateDienNuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 620);
            Controls.Add(lblTitle);
            Controls.Add(btnXacNhan);
            Controls.Add(txtNuoc);
            Controls.Add(txtDien);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUpdateDienNuoc";
            Text = "Cập nhật điện nước";
            Load += frmUpdateDienNuoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDien;
        private TextBox txtNuoc;
        private Button btnXacNhan;
        private Label lblTitle;
    }
}