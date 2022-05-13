namespace DiscordAnimatedActivity
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTools = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTool = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTools,
            this.activityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolTools
            // 
            this.toolTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTool,
            this.exitTool});
            this.toolTools.Name = "toolTools";
            this.toolTools.Size = new System.Drawing.Size(46, 20);
            this.toolTools.Text = "Tools";
            // 
            // settingsTool
            // 
            this.settingsTool.Name = "settingsTool";
            this.settingsTool.Size = new System.Drawing.Size(180, 22);
            this.settingsTool.Text = "Settings";
            this.settingsTool.Click += new System.EventHandler(this.settingsTool_Click);
            // 
            // exitTool
            // 
            this.exitTool.Name = "exitTool";
            this.exitTool.Size = new System.Drawing.Size(180, 22);
            this.exitTool.Text = "Exit";
            this.exitTool.Click += new System.EventHandler(this.exitTool_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTool,
            this.pauseTool,
            this.stopTool});
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.activityToolStripMenuItem.Text = "Activity";
            // 
            // startTool
            // 
            this.startTool.Name = "startTool";
            this.startTool.Size = new System.Drawing.Size(105, 22);
            this.startTool.Text = "Start";
            // 
            // pauseTool
            // 
            this.pauseTool.Name = "pauseTool";
            this.pauseTool.Size = new System.Drawing.Size(105, 22);
            this.pauseTool.Text = "Pause";
            // 
            // stopTool
            // 
            this.stopTool.Name = "stopTool";
            this.stopTool.Size = new System.Drawing.Size(105, 22);
            this.stopTool.Text = "Stop";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolTools;
        private System.Windows.Forms.ToolStripMenuItem settingsTool;
        private System.Windows.Forms.ToolStripMenuItem exitTool;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTool;
        private System.Windows.Forms.ToolStripMenuItem pauseTool;
        private System.Windows.Forms.ToolStripMenuItem stopTool;
    }
}

