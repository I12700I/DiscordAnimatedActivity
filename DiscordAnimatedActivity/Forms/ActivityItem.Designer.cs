namespace DiscordAnimatedActivity.Forms
{
    partial class ActivityItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityItem));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smallkey = new System.Windows.Forms.TextBox();
            this.largeplaceholder = new System.Windows.Forms.TextBox();
            this.largekey = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.toolTime = new System.Windows.Forms.ToolTip(this.components);
            this.timetypebox = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.revertbtn = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.smallplaceholder = new System.Windows.Forms.TextBox();
            this.btnfirsturl = new System.Windows.Forms.TextBox();
            this.btnfirsttext = new System.Windows.Forms.TextBox();
            this.btnsecondurl = new System.Windows.Forms.TextBox();
            this.btnsecondtext = new System.Windows.Forms.TextBox();
            this.randomlarge = new System.Windows.Forms.CheckBox();
            this.randomsmall = new System.Windows.Forms.CheckBox();
            this.globalbtns = new System.Windows.Forms.CheckBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.globaltime = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Whitney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLAYING A GAME";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.smallkey);
            this.panel1.Controls.Add(this.largeplaceholder);
            this.panel1.Controls.Add(this.largekey);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
            this.panel1.TabIndex = 1;
            // 
            // smallkey
            // 
            this.smallkey.Location = new System.Drawing.Point(25, 93);
            this.smallkey.Name = "smallkey";
            this.smallkey.Size = new System.Drawing.Size(100, 20);
            this.smallkey.TabIndex = 6;
            // 
            // largeplaceholder
            // 
            this.largeplaceholder.Location = new System.Drawing.Point(25, 36);
            this.largeplaceholder.Name = "largeplaceholder";
            this.largeplaceholder.Size = new System.Drawing.Size(100, 20);
            this.largeplaceholder.TabIndex = 6;
            // 
            // largekey
            // 
            this.largekey.Location = new System.Drawing.Point(10, 9);
            this.largekey.Name = "largekey";
            this.largekey.Size = new System.Drawing.Size(100, 20);
            this.largekey.TabIndex = 6;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(150, 122);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 3;
            this.time.Text = "0";
            this.toolTime.SetToolTip(this.time, "Enter time in seconds for to use the current time with an offset \r\nThe default of" +
        "fset is 0");
            // 
            // timetypebox
            // 
            this.timetypebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timetypebox.FormattingEnabled = true;
            this.timetypebox.Items.AddRange(new object[] {
            "don\'t use the time",
            "elapsed",
            "left"});
            this.timetypebox.Location = new System.Drawing.Point(256, 122);
            this.timetypebox.Name = "timetypebox";
            this.timetypebox.Size = new System.Drawing.Size(110, 21);
            this.timetypebox.TabIndex = 2;
            this.timetypebox.SelectedIndexChanged += new System.EventHandler(this.timetype_SelectedIndexChanged);
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.Location = new System.Drawing.Point(160, 329);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // revertbtn
            // 
            this.revertbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.revertbtn.Location = new System.Drawing.Point(241, 329);
            this.revertbtn.Name = "revertbtn";
            this.revertbtn.Size = new System.Drawing.Size(75, 23);
            this.revertbtn.TabIndex = 5;
            this.revertbtn.Text = "Revert";
            this.revertbtn.UseVisualStyleBackColor = true;
            this.revertbtn.Click += new System.EventHandler(this.revertbtn_Click);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(150, 42);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(100, 20);
            this.details.TabIndex = 6;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(150, 78);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 20);
            this.state.TabIndex = 6;
            // 
            // smallplaceholder
            // 
            this.smallplaceholder.Location = new System.Drawing.Point(55, 162);
            this.smallplaceholder.Name = "smallplaceholder";
            this.smallplaceholder.Size = new System.Drawing.Size(100, 20);
            this.smallplaceholder.TabIndex = 6;
            // 
            // btnfirsturl
            // 
            this.btnfirsturl.Location = new System.Drawing.Point(13, 205);
            this.btnfirsturl.Name = "btnfirsturl";
            this.btnfirsturl.Size = new System.Drawing.Size(171, 20);
            this.btnfirsturl.TabIndex = 7;
            // 
            // btnfirsttext
            // 
            this.btnfirsttext.Location = new System.Drawing.Point(190, 205);
            this.btnfirsttext.Name = "btnfirsttext";
            this.btnfirsttext.Size = new System.Drawing.Size(173, 20);
            this.btnfirsttext.TabIndex = 7;
            // 
            // btnsecondurl
            // 
            this.btnsecondurl.Location = new System.Drawing.Point(13, 251);
            this.btnsecondurl.Name = "btnsecondurl";
            this.btnsecondurl.Size = new System.Drawing.Size(171, 20);
            this.btnsecondurl.TabIndex = 7;
            // 
            // btnsecondtext
            // 
            this.btnsecondtext.Location = new System.Drawing.Point(190, 251);
            this.btnsecondtext.Name = "btnsecondtext";
            this.btnsecondtext.Size = new System.Drawing.Size(173, 20);
            this.btnsecondtext.TabIndex = 7;
            // 
            // randomlarge
            // 
            this.randomlarge.AutoSize = true;
            this.randomlarge.Location = new System.Drawing.Point(12, 278);
            this.randomlarge.Name = "randomlarge";
            this.randomlarge.Size = new System.Drawing.Size(92, 17);
            this.randomlarge.TabIndex = 8;
            this.randomlarge.Text = "Random large";
            this.randomlarge.UseVisualStyleBackColor = true;
            this.randomlarge.CheckedChanged += new System.EventHandler(this.randoms_CheckedChanged);
            // 
            // randomsmall
            // 
            this.randomsmall.AutoSize = true;
            this.randomsmall.Location = new System.Drawing.Point(110, 278);
            this.randomsmall.Name = "randomsmall";
            this.randomsmall.Size = new System.Drawing.Size(92, 17);
            this.randomsmall.TabIndex = 8;
            this.randomsmall.Text = "Random small";
            this.randomsmall.UseVisualStyleBackColor = true;
            this.randomsmall.CheckedChanged += new System.EventHandler(this.randoms_CheckedChanged);
            // 
            // globalbtns
            // 
            this.globalbtns.AutoSize = true;
            this.globalbtns.Location = new System.Drawing.Point(208, 278);
            this.globalbtns.Name = "globalbtns";
            this.globalbtns.Size = new System.Drawing.Size(94, 17);
            this.globalbtns.TabIndex = 8;
            this.globalbtns.Text = "Global buttons";
            this.globalbtns.UseVisualStyleBackColor = true;
            this.globalbtns.CheckedChanged += new System.EventHandler(this.globalbtns_CheckedChanged);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.Location = new System.Drawing.Point(322, 329);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // globaltime
            // 
            this.globaltime.AutoSize = true;
            this.globaltime.Location = new System.Drawing.Point(308, 277);
            this.globaltime.Name = "globaltime";
            this.globaltime.Size = new System.Drawing.Size(78, 17);
            this.globaltime.TabIndex = 8;
            this.globaltime.Text = "Global time";
            this.globaltime.UseVisualStyleBackColor = true;
            this.globaltime.CheckedChanged += new System.EventHandler(this.globalbtns_CheckedChanged);
            // 
            // ActivityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(409, 364);
            this.Controls.Add(this.globaltime);
            this.Controls.Add(this.globalbtns);
            this.Controls.Add(this.randomsmall);
            this.Controls.Add(this.randomlarge);
            this.Controls.Add(this.btnsecondtext);
            this.Controls.Add(this.btnfirsttext);
            this.Controls.Add(this.btnsecondurl);
            this.Controls.Add(this.btnfirsturl);
            this.Controls.Add(this.smallplaceholder);
            this.Controls.Add(this.state);
            this.Controls.Add(this.details);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.revertbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.time);
            this.Controls.Add(this.timetypebox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivityItem";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.revertbtn_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.ToolTip toolTime;
        private System.Windows.Forms.ComboBox timetypebox;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button revertbtn;
        private System.Windows.Forms.TextBox smallkey;
        private System.Windows.Forms.TextBox largekey;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox largeplaceholder;
        private System.Windows.Forms.TextBox smallplaceholder;
        private System.Windows.Forms.TextBox btnfirsturl;
        private System.Windows.Forms.TextBox btnfirsttext;
        private System.Windows.Forms.TextBox btnsecondurl;
        private System.Windows.Forms.TextBox btnsecondtext;
        private System.Windows.Forms.CheckBox randomlarge;
        private System.Windows.Forms.CheckBox randomsmall;
        private System.Windows.Forms.CheckBox globalbtns;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.CheckBox globaltime;
    }
}