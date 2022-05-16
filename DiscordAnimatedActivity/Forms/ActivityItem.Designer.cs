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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smallkey = new System.Windows.Forms.TextBox();
            this.largekey = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.toolTime = new System.Windows.Forms.ToolTip(this.components);
            this.timetypebox = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.revertbtn = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.largeplaceholder = new System.Windows.Forms.TextBox();
            this.smallplaceholder = new System.Windows.Forms.TextBox();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Whitney Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Whitney Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "LargeKey";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Whitney Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(117, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "SmallKey";
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
            // largekey
            // 
            this.largekey.Location = new System.Drawing.Point(10, 9);
            this.largekey.Name = "largekey";
            this.largekey.Size = new System.Drawing.Size(100, 20);
            this.largekey.TabIndex = 6;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(147, 122);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 3;
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
            this.timetypebox.Location = new System.Drawing.Point(253, 122);
            this.timetypebox.Name = "timetypebox";
            this.timetypebox.Size = new System.Drawing.Size(110, 21);
            this.timetypebox.TabIndex = 2;
            this.timetypebox.SelectedIndexChanged += new System.EventHandler(this.timetype_SelectedIndexChanged);
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.Location = new System.Drawing.Point(241, 159);
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
            this.revertbtn.Location = new System.Drawing.Point(322, 159);
            this.revertbtn.Name = "revertbtn";
            this.revertbtn.Size = new System.Drawing.Size(75, 23);
            this.revertbtn.TabIndex = 5;
            this.revertbtn.Text = "Revert";
            this.revertbtn.UseVisualStyleBackColor = true;
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
            // largeplaceholder
            // 
            this.largeplaceholder.Location = new System.Drawing.Point(25, 36);
            this.largeplaceholder.Name = "largeplaceholder";
            this.largeplaceholder.Size = new System.Drawing.Size(100, 20);
            this.largeplaceholder.TabIndex = 6;
            // 
            // smallplaceholder
            // 
            this.smallplaceholder.Location = new System.Drawing.Point(55, 162);
            this.smallplaceholder.Name = "smallplaceholder";
            this.smallplaceholder.Size = new System.Drawing.Size(100, 20);
            this.smallplaceholder.TabIndex = 6;
            // 
            // ActivityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(409, 194);
            this.Controls.Add(this.smallplaceholder);
            this.Controls.Add(this.state);
            this.Controls.Add(this.details);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox largeplace;
        private System.Windows.Forms.TextBox smallplace;
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
    }
}