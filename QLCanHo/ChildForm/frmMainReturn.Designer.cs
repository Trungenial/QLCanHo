namespace QLCanHo.ChildForm
{
    partial class frmMainReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainReturn));
            pnMain = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            lblDaDuocThue = new Label();
            label5 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            lblSoCanHo = new Label();
            label4 = new Label();
            pnMain.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(0, 0, 0, 0);
            pnMain.BackgroundImage = (Image)resources.GetObject("pnMain.BackgroundImage");
            pnMain.BackgroundImageLayout = ImageLayout.Stretch;
            pnMain.Controls.Add(panel4);
            pnMain.Controls.Add(panel3);
            pnMain.Dock = DockStyle.Right;
            pnMain.Location = new Point(-162, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1143, 620);
            pnMain.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(lblDaDuocThue);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(718, 87);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 281);
            panel4.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblDaDuocThue
            // 
            lblDaDuocThue.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDaDuocThue.Location = new Point(3, 121);
            lblDaDuocThue.Name = "lblDaDuocThue";
            lblDaDuocThue.Size = new Size(330, 48);
            lblDaDuocThue.TabIndex = 1;
            lblDaDuocThue.Text = "0";
            lblDaDuocThue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-2, -9);
            label5.Name = "label5";
            label5.Size = new Size(281, 92);
            label5.TabIndex = 0;
            label5.Text = "Đang hoạt động";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lblSoCanHo);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(260, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 281);
            panel3.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblSoCanHo
            // 
            lblSoCanHo.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoCanHo.Location = new Point(-2, 121);
            lblSoCanHo.Name = "lblSoCanHo";
            lblSoCanHo.Size = new Size(330, 48);
            lblSoCanHo.TabIndex = 1;
            lblSoCanHo.Text = "0";
            lblSoCanHo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 14);
            label4.Name = "label4";
            label4.Size = new Size(174, 46);
            label4.TabIndex = 0;
            label4.Text = "Số căn hộ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMainReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 620);
            Controls.Add(pnMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMainReturn";
            Text = "frmMainReturn";
            Load += frmMainReturn_Load;
            pnMain.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label lblDaDuocThue;
        private Label label5;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label lblSoCanHo;
        private Label label4;
        private PictureBox pictureBox4;
    }
}