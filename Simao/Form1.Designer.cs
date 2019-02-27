namespace Simao
{
    partial class SiMao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiMao));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.心情值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBase = new System.Windows.Forms.Timer(this.components);
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerFast = new System.Windows.Forms.Timer(this.components);
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "可爱的四毛";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.控制ToolStripMenuItem,
            this.隐藏ToolStripMenuItem,
            this.状态ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 144);
            // 
            // 控制ToolStripMenuItem
            // 
            this.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
            this.控制ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.控制ToolStripMenuItem.Text = "显示";
            this.控制ToolStripMenuItem.Click += new System.EventHandler(this.控制ToolStripMenuItem_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.隐藏ToolStripMenuItem.Text = "隐藏";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏ToolStripMenuItem_Click);
            // 
            // 状态ToolStripMenuItem
            // 
            this.状态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.心情值ToolStripMenuItem});
            this.状态ToolStripMenuItem.Name = "状态ToolStripMenuItem";
            this.状态ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.状态ToolStripMenuItem.Text = "状态";
            // 
            // 心情值ToolStripMenuItem
            // 
            this.心情值ToolStripMenuItem.Name = "心情值ToolStripMenuItem";
            this.心情值ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.心情值ToolStripMenuItem.Text = "心情值：";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // timerBase
            // 
            this.timerBase.Enabled = true;
            this.timerBase.Interval = 3000;
            this.timerBase.Tick += new System.EventHandler(this.timerBase_Tick);
            // 
            // timerRandom
            // 
            this.timerRandom.Enabled = true;
            this.timerRandom.Interval = 300000;
            this.timerRandom.Tick += new System.EventHandler(this.timerRandom_Tick);
            // 
            // timerEvent
            // 
            this.timerEvent.Interval = 3000;
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // label1
            // 
            this.label1.Image = global::Simao.Properties.Resources.我来了;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 225);
            this.label1.TabIndex = 0;
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // timerFast
            // 
            this.timerFast.Enabled = true;
            this.timerFast.Interval = 500;
            this.timerFast.Tick += new System.EventHandler(this.timerFast_Tick);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // SiMao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(225, 225);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SiMao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SiMao_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timerBase;
        private System.Windows.Forms.Timer timerRandom;
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.ToolStripMenuItem 状态ToolStripMenuItem;
        private System.Windows.Forms.Timer timerFast;
        private System.Windows.Forms.ToolStripMenuItem 心情值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}

