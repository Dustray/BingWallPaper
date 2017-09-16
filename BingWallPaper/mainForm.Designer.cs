namespace BingWallPaper
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.wStyleFull = new System.Windows.Forms.RadioButton();
            this.wStyleAdapt = new System.Windows.Forms.RadioButton();
            this.wStyleStretch = new System.Windows.Forms.RadioButton();
            this.wStyleTiling = new System.Windows.Forms.RadioButton();
            this.wStyleCenter = new System.Windows.Forms.RadioButton();
            this.wStyleSpan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageSize1080 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageSize1080full = new System.Windows.Forms.RadioButton();
            this.imageSize720 = new System.Windows.Forms.RadioButton();
            this.savePath = new System.Windows.Forms.TextBox();
            this.chooseSavePath = new System.Windows.Forms.Button();
            this.chooseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.autoRunCheck = new System.Windows.Forms.CheckBox();
            this.notSaveImage = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.setStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(442, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "测试按钮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "图片保存路径：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("黑体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(736, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "应用(手动获取)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wStyleFull
            // 
            this.wStyleFull.AutoSize = true;
            this.wStyleFull.Checked = true;
            this.wStyleFull.Location = new System.Drawing.Point(24, 20);
            this.wStyleFull.Name = "wStyleFull";
            this.wStyleFull.Size = new System.Drawing.Size(58, 19);
            this.wStyleFull.TabIndex = 4;
            this.wStyleFull.TabStop = true;
            this.wStyleFull.Text = "填充";
            this.wStyleFull.UseVisualStyleBackColor = true;
            this.wStyleFull.CheckedChanged += new System.EventHandler(this.wStyleFull_CheckedChanged);
            // 
            // wStyleAdapt
            // 
            this.wStyleAdapt.AutoSize = true;
            this.wStyleAdapt.Location = new System.Drawing.Point(115, 20);
            this.wStyleAdapt.Name = "wStyleAdapt";
            this.wStyleAdapt.Size = new System.Drawing.Size(58, 19);
            this.wStyleAdapt.TabIndex = 5;
            this.wStyleAdapt.Text = "适应";
            this.wStyleAdapt.UseVisualStyleBackColor = true;
            this.wStyleAdapt.CheckedChanged += new System.EventHandler(this.wStyleAdapt_CheckedChanged);
            // 
            // wStyleStretch
            // 
            this.wStyleStretch.AutoSize = true;
            this.wStyleStretch.Location = new System.Drawing.Point(24, 45);
            this.wStyleStretch.Name = "wStyleStretch";
            this.wStyleStretch.Size = new System.Drawing.Size(58, 19);
            this.wStyleStretch.TabIndex = 6;
            this.wStyleStretch.Text = "拉伸";
            this.wStyleStretch.UseVisualStyleBackColor = true;
            this.wStyleStretch.CheckedChanged += new System.EventHandler(this.wStyleStretch_CheckedChanged);
            // 
            // wStyleTiling
            // 
            this.wStyleTiling.AutoSize = true;
            this.wStyleTiling.Location = new System.Drawing.Point(115, 45);
            this.wStyleTiling.Name = "wStyleTiling";
            this.wStyleTiling.Size = new System.Drawing.Size(58, 19);
            this.wStyleTiling.TabIndex = 7;
            this.wStyleTiling.TabStop = true;
            this.wStyleTiling.Text = "平铺";
            this.wStyleTiling.UseVisualStyleBackColor = true;
            this.wStyleTiling.CheckedChanged += new System.EventHandler(this.wStyleTiling_CheckedChanged);
            // 
            // wStyleCenter
            // 
            this.wStyleCenter.AutoSize = true;
            this.wStyleCenter.Location = new System.Drawing.Point(24, 70);
            this.wStyleCenter.Name = "wStyleCenter";
            this.wStyleCenter.Size = new System.Drawing.Size(58, 19);
            this.wStyleCenter.TabIndex = 8;
            this.wStyleCenter.TabStop = true;
            this.wStyleCenter.Text = "居中";
            this.wStyleCenter.UseVisualStyleBackColor = true;
            this.wStyleCenter.CheckedChanged += new System.EventHandler(this.wStyleCenter_CheckedChanged);
            // 
            // wStyleSpan
            // 
            this.wStyleSpan.AutoSize = true;
            this.wStyleSpan.Location = new System.Drawing.Point(115, 69);
            this.wStyleSpan.Name = "wStyleSpan";
            this.wStyleSpan.Size = new System.Drawing.Size(58, 19);
            this.wStyleSpan.TabIndex = 9;
            this.wStyleSpan.TabStop = true;
            this.wStyleSpan.Text = "跨区";
            this.wStyleSpan.UseVisualStyleBackColor = true;
            this.wStyleSpan.CheckedChanged += new System.EventHandler(this.wStyleSpan_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.wStyleTiling);
            this.groupBox1.Controls.Add(this.wStyleSpan);
            this.groupBox1.Controls.Add(this.wStyleFull);
            this.groupBox1.Controls.Add(this.wStyleCenter);
            this.groupBox1.Controls.Add(this.wStyleAdapt);
            this.groupBox1.Controls.Add(this.wStyleStretch);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 97);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "壁纸样式";
            // 
            // imageSize1080
            // 
            this.imageSize1080.AutoSize = true;
            this.imageSize1080.Checked = true;
            this.imageSize1080.Location = new System.Drawing.Point(25, 44);
            this.imageSize1080.Name = "imageSize1080";
            this.imageSize1080.Size = new System.Drawing.Size(164, 19);
            this.imageSize1080.TabIndex = 11;
            this.imageSize1080.TabStop = true;
            this.imageSize1080.Text = "1080p (1920x1080)";
            this.imageSize1080.UseVisualStyleBackColor = true;
            this.imageSize1080.CheckedChanged += new System.EventHandler(this.imageSize1080_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.imageSize1080full);
            this.groupBox2.Controls.Add(this.imageSize720);
            this.groupBox2.Controls.Add(this.imageSize1080);
            this.groupBox2.Location = new System.Drawing.Point(11, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 96);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "壁纸尺寸";
            // 
            // imageSize1080full
            // 
            this.imageSize1080full.AutoSize = true;
            this.imageSize1080full.Location = new System.Drawing.Point(25, 19);
            this.imageSize1080full.Name = "imageSize1080full";
            this.imageSize1080full.Size = new System.Drawing.Size(164, 19);
            this.imageSize1080full.TabIndex = 13;
            this.imageSize1080full.Text = "1080p (1920x1200)";
            this.imageSize1080full.UseVisualStyleBackColor = true;
            this.imageSize1080full.CheckedChanged += new System.EventHandler(this.imageSize1080full_CheckedChanged);
            // 
            // imageSize720
            // 
            this.imageSize720.AutoSize = true;
            this.imageSize720.Location = new System.Drawing.Point(25, 69);
            this.imageSize720.Name = "imageSize720";
            this.imageSize720.Size = new System.Drawing.Size(156, 19);
            this.imageSize720.TabIndex = 12;
            this.imageSize720.Text = "720p  (1366x768)";
            this.imageSize720.UseVisualStyleBackColor = true;
            this.imageSize720.CheckedChanged += new System.EventHandler(this.imageSize720_CheckedChanged);
            // 
            // savePath
            // 
            this.savePath.AllowDrop = true;
            this.savePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePath.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.savePath.Location = new System.Drawing.Point(144, 451);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(652, 34);
            this.savePath.TabIndex = 13;
            this.savePath.Leave += new System.EventHandler(this.savePath_Leave);
            // 
            // chooseSavePath
            // 
            this.chooseSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseSavePath.BackColor = System.Drawing.Color.Transparent;
            this.chooseSavePath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseSavePath.Location = new System.Drawing.Point(803, 451);
            this.chooseSavePath.Name = "chooseSavePath";
            this.chooseSavePath.Size = new System.Drawing.Size(97, 34);
            this.chooseSavePath.TabIndex = 14;
            this.chooseSavePath.Text = "选 择";
            this.chooseSavePath.UseVisualStyleBackColor = false;
            this.chooseSavePath.Click += new System.EventHandler(this.chooseSavePath_Click);
            // 
            // autoRunCheck
            // 
            this.autoRunCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.autoRunCheck.AutoSize = true;
            this.autoRunCheck.BackColor = System.Drawing.Color.Transparent;
            this.autoRunCheck.Checked = true;
            this.autoRunCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRunCheck.Location = new System.Drawing.Point(581, 415);
            this.autoRunCheck.Name = "autoRunCheck";
            this.autoRunCheck.Size = new System.Drawing.Size(149, 19);
            this.autoRunCheck.TabIndex = 15;
            this.autoRunCheck.Text = "开机自动设置壁纸";
            this.autoRunCheck.UseVisualStyleBackColor = false;
            this.autoRunCheck.CheckedChanged += new System.EventHandler(this.autoRunCheck_CheckedChanged);
            // 
            // notSaveImage
            // 
            this.notSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notSaveImage.AutoSize = true;
            this.notSaveImage.BackColor = System.Drawing.Color.Transparent;
            this.notSaveImage.Location = new System.Drawing.Point(242, 416);
            this.notSaveImage.Name = "notSaveImage";
            this.notSaveImage.Size = new System.Drawing.Size(194, 19);
            this.notSaveImage.TabIndex = 16;
            this.notSaveImage.Text = "不保存图片（每日删除）";
            this.notSaveImage.UseVisualStyleBackColor = false;
            this.notSaveImage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.savePath);
            this.panel1.Controls.Add(this.notSaveImage);
            this.panel1.Controls.Add(this.autoRunCheck);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chooseSavePath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 523);
            this.panel1.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(11, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 219);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "软件说明";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.MaximumSize = new System.Drawing.Size(190, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 180);
            this.label2.TabIndex = 0;
            this.label2.Text = "·本软件在.NET Framework 4.0及以上版本支持下工作；\r\n·在Windows 7系统上不能成功设置壁纸，但可以将图片保存到本地，Windows 8、" +
    "Windows 10完美运行；\r\n·设置后立即执行，无需点击“应用”按钮；\r\n·作者：Dustray；\r\n·网站：dustray.cn；\r\n·版本：1.0.0。" +
    "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(214, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(686, 390);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setStatusLabel,
            this.statusProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 25);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // setStatusLabel
            // 
            this.setStatusLabel.Name = "setStatusLabel";
            this.setStatusLabel.Size = new System.Drawing.Size(69, 20);
            this.setStatusLabel.Text = "状态标签";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusProgressBar.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(300, 19);
            // 
            // mainForm
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(930, 570);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "每日桌面必应壁纸";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton wStyleFull;
        private System.Windows.Forms.RadioButton wStyleAdapt;
        private System.Windows.Forms.RadioButton wStyleStretch;
        private System.Windows.Forms.RadioButton wStyleTiling;
        private System.Windows.Forms.RadioButton wStyleCenter;
        private System.Windows.Forms.RadioButton wStyleSpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton imageSize1080;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton imageSize720;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.Button chooseSavePath;
        private System.Windows.Forms.FolderBrowserDialog chooseFolderDialog;
        private System.Windows.Forms.CheckBox autoRunCheck;
        private System.Windows.Forms.CheckBox notSaveImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton imageSize1080full;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel setStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
    }
}

