namespace DiscordAnimatedActivity
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addActivity = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialMenuStrip1 = new MaterialSkin.Controls.MaterialMenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTool = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTool = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTool = new System.Windows.Forms.ToolStripMenuItem();
            this.materialMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 380);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // addActivity
            // 
            this.addActivity.AutoSize = true;
            this.addActivity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addActivity.Depth = 0;
            this.addActivity.Icon = null;
            this.addActivity.Location = new System.Drawing.Point(639, 35);
            this.addActivity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addActivity.MaximumSize = new System.Drawing.Size(0, 22);
            this.addActivity.MouseState = MaterialSkin.MouseState.HOVER;
            this.addActivity.Name = "addActivity";
            this.addActivity.Primary = false;
            this.addActivity.Size = new System.Drawing.Size(144, 22);
            this.addActivity.TabIndex = 4;
            this.addActivity.Text = "Add new activity";
            this.addActivity.UseVisualStyleBackColor = true;
            this.addActivity.Click += new System.EventHandler(this.AddActivity_Click);
            // 
            // materialMenuStrip1
            // 
            this.materialMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialMenuStrip1.Depth = 0;
            this.materialMenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.materialMenuStrip1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.activityToolStripMenuItem});
            this.materialMenuStrip1.Location = new System.Drawing.Point(12, 31);
            this.materialMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMenuStrip1.Name = "materialMenuStrip1";
            this.materialMenuStrip1.Size = new System.Drawing.Size(128, 26);
            this.materialMenuStrip1.TabIndex = 6;
            this.materialMenuStrip1.Text = "materialMenuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTool,
            this.exitTool});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsTool
            // 
            this.settingsTool.Name = "settingsTool";
            this.settingsTool.Size = new System.Drawing.Size(127, 22);
            this.settingsTool.Text = "Settings";
            this.settingsTool.Click += new System.EventHandler(this.SettingsTool_Click);
            // 
            // exitTool
            // 
            this.exitTool.Name = "exitTool";
            this.exitTool.Size = new System.Drawing.Size(127, 22);
            this.exitTool.Text = "Exit";
            this.exitTool.Click += new System.EventHandler(this.ExitTool_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.activityToolStripMenuItem.Text = "Activity";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTool,
            this.pauseTool,
            this.stopTool});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // startTool
            // 
            this.startTool.Name = "startTool";
            this.startTool.Size = new System.Drawing.Size(115, 22);
            this.startTool.Text = "Start";
            this.startTool.Click += new System.EventHandler(this.StartTool_Click);
            // 
            // pauseTool
            // 
            this.pauseTool.Name = "pauseTool";
            this.pauseTool.Size = new System.Drawing.Size(115, 22);
            this.pauseTool.Text = "Pause";
            // 
            // stopTool
            // 
            this.stopTool.Name = "stopTool";
            this.stopTool.Size = new System.Drawing.Size(115, 22);
            this.stopTool.Text = "Stop";
            this.stopTool.Click += new System.EventHandler(this.StopTool_Click);
            // 
            // Main
            // 
            this.ActionBarBound = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.addActivity);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.materialMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.materialMenuStrip1;
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "Main";
            this.StatusBarBound = true;
            this.Text = "Discord animated activity";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.materialMenuStrip1.ResumeLayout(false);
            this.materialMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialFlatButton addActivity;
        private MaterialSkin.Controls.MaterialMenuStrip materialMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsTool;
        private System.Windows.Forms.ToolStripMenuItem exitTool;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTool;
        private System.Windows.Forms.ToolStripMenuItem pauseTool;
        private System.Windows.Forms.ToolStripMenuItem stopTool;
    }
}

