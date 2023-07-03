namespace QuanLyTruongHoc
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuQuanLyHS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyGV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyLH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyMH = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(931, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuQuanLyHS
            // 
            this.menuQuanLyHS.BackColor = System.Drawing.SystemColors.Info;
            this.menuQuanLyHS.Name = "menuQuanLyHS";
            this.menuQuanLyHS.Size = new System.Drawing.Size(131, 24);
            this.menuQuanLyHS.Text = "Quản lý học sinh";
            this.menuQuanLyHS.Click += new System.EventHandler(this.menuQuanLyHS_Click);
            // 
            // menuQuanLyGV
            // 
            this.menuQuanLyGV.BackColor = System.Drawing.SystemColors.Info;
            this.menuQuanLyGV.Name = "menuQuanLyGV";
            this.menuQuanLyGV.Size = new System.Drawing.Size(138, 24);
            this.menuQuanLyGV.Text = "Quản lý giáo viên";
            this.menuQuanLyGV.Click += new System.EventHandler(this.menuQuanLyGV_Click);
            // 
            // menuQuanLyLH
            // 
            this.menuQuanLyLH.BackColor = System.Drawing.SystemColors.Info;
            this.menuQuanLyLH.Name = "menuQuanLyLH";
            this.menuQuanLyLH.Size = new System.Drawing.Size(127, 24);
            this.menuQuanLyLH.Text = "Quản lý lớp học";
            this.menuQuanLyLH.Click += new System.EventHandler(this.menuQuanLyLH_Click);
            // 
            // menuQuanLyD
            // 
            this.menuQuanLyD.BackColor = System.Drawing.SystemColors.Info;
            this.menuQuanLyD.Name = "menuQuanLyD";
            this.menuQuanLyD.Size = new System.Drawing.Size(111, 24);
            this.menuQuanLyD.Text = "Quản lý điểm";
            this.menuQuanLyD.Click += new System.EventHandler(this.menuQuanLyD_Click);
            // 
            // menuQuanLyMH
            // 
            this.menuQuanLyMH.BackColor = System.Drawing.SystemColors.Info;
            this.menuQuanLyMH.Name = "menuQuanLyMH";
            this.menuQuanLyMH.Size = new System.Drawing.Size(135, 24);
            this.menuQuanLyMH.Text = "Quản lý môn học";
            this.menuQuanLyMH.Click += new System.EventHandler(this.menuQuanLyMH_Click);
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "HDSD";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyHS,
            this.menuQuanLyGV,
            this.menuQuanLyLH,
            this.menuQuanLyD,
            this.menuQuanLyMH,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2013",
            "2012"});
            this.cbNam.Location = new System.Drawing.Point(74, 31);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(128, 28);
            this.cbNam.TabIndex = 2;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm học";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStripMenuItem menuQuanLyHS;
        private ToolStripMenuItem menuQuanLyGV;
        private ToolStripMenuItem menuQuanLyLH;
        private ToolStripMenuItem menuQuanLyD;
        private ToolStripMenuItem menuQuanLyMH;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ComboBox cbNam;
        private Label label1;
    }
}