namespace QLCanHo.ChildForm
{
    partial class frmChotDienNuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChotDienNuoc));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCSD_Cu = new TextBox();
            txtCSD_Moi = new TextBox();
            btnXacNhan = new Button();
            txtCSN_Cu = new TextBox();
            txtCSN_Moi = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 17);
            label1.TabIndex = 0;
            label1.Text = "Chi số điện cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(69, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 0;
            label2.Text = "Chỉ số điện mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(360, 91);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 17);
            label3.TabIndex = 0;
            label3.Text = "Chỉ số nước cũ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(360, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 0;
            label4.Text = "Chỉ số nước mới";
            // 
            // txtCSD_Cu
            // 
            txtCSD_Cu.BackColor = Color.White;
            txtCSD_Cu.Location = new Point(189, 86);
            txtCSD_Cu.Margin = new Padding(4, 5, 4, 5);
            txtCSD_Cu.Name = "txtCSD_Cu";
            txtCSD_Cu.ReadOnly = true;
            txtCSD_Cu.Size = new Size(156, 27);
            txtCSD_Cu.TabIndex = 1;
            txtCSD_Cu.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCSD_Moi
            // 
            txtCSD_Moi.Location = new Point(189, 126);
            txtCSD_Moi.Margin = new Padding(4, 5, 4, 5);
            txtCSD_Moi.Name = "txtCSD_Moi";
            txtCSD_Moi.Size = new Size(156, 27);
            txtCSD_Moi.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.White;
            btnXacNhan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.Black;
            btnXacNhan.Location = new Point(293, 202);
            btnXacNhan.Margin = new Padding(4, 5, 4, 5);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(147, 35);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtCSN_Cu
            // 
            txtCSN_Cu.BackColor = Color.White;
            txtCSN_Cu.Location = new Point(487, 86);
            txtCSN_Cu.Margin = new Padding(4, 5, 4, 5);
            txtCSN_Cu.Name = "txtCSN_Cu";
            txtCSN_Cu.ReadOnly = true;
            txtCSN_Cu.Size = new Size(156, 27);
            txtCSN_Cu.TabIndex = 2;
            txtCSN_Cu.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCSN_Moi
            // 
            txtCSN_Moi.Location = new Point(487, 126);
            txtCSN_Moi.Margin = new Padding(4, 5, 4, 5);
            txtCSN_Moi.Name = "txtCSN_Moi";
            txtCSN_Moi.Size = new Size(156, 27);
            txtCSN_Moi.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            groupBox1.Controls.Add(txtCSN_Moi);
            groupBox1.Controls.Add(txtCSN_Cu);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(txtCSD_Moi);
            groupBox1.Controls.Add(txtCSD_Cu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 29);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(733, 331);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // frmChotDienNuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(733, 360);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmChotDienNuoc";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chốt điện nước";
            Load += frmChotDienNuoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCSD_Cu;
        private TextBox txtCSD_Moi;
        private Button btnXacNhan;
        private TextBox txtCSN_Cu;
        private TextBox txtCSN_Moi;
        private GroupBox groupBox1;
    }
}