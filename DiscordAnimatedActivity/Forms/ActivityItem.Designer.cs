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
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smallkey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.largeplaceholder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.largekey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.time = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolTime = new System.Windows.Forms.ToolTip(this.components);
            this.timetypebox = new System.Windows.Forms.ComboBox();
            this.savebtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.revertbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.details = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.state = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.smallplaceholder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnfirsturl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnfirsttext = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnsecondurl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnsecondtext = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.randomlarge = new MaterialSkin.Controls.MaterialCheckBox();
            this.randomsmall = new MaterialSkin.Controls.MaterialCheckBox();
            this.globalbtns = new MaterialSkin.Controls.MaterialCheckBox();
            this.deletebtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.globaltime = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
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
            this.panel1.Controls.Add(this.smallplaceholder);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
            this.panel1.TabIndex = 1;
            // 
            // smallkey
            // 
            this.smallkey.Depth = 0;
            this.smallkey.Hint = "";
            this.smallkey.Location = new System.Drawing.Point(10, 78);
            this.smallkey.MaxLength = 32767;
            this.smallkey.MouseState = MaterialSkin.MouseState.HOVER;
            this.smallkey.Name = "smallkey";
            this.smallkey.PasswordChar = '\0';
            this.smallkey.SelectedText = "";
            this.smallkey.SelectionLength = 0;
            this.smallkey.SelectionStart = 0;
            this.smallkey.Size = new System.Drawing.Size(100, 23);
            this.smallkey.TabIndex = 6;
            this.smallkey.TabStop = false;
            this.smallkey.UseSystemPasswordChar = false;
            // 
            // largeplaceholder
            // 
            this.largeplaceholder.Depth = 0;
            this.largeplaceholder.Hint = "";
            this.largeplaceholder.Location = new System.Drawing.Point(25, 36);
            this.largeplaceholder.MaxLength = 32767;
            this.largeplaceholder.MouseState = MaterialSkin.MouseState.HOVER;
            this.largeplaceholder.Name = "largeplaceholder";
            this.largeplaceholder.PasswordChar = '\0';
            this.largeplaceholder.SelectedText = "";
            this.largeplaceholder.SelectionLength = 0;
            this.largeplaceholder.SelectionStart = 0;
            this.largeplaceholder.Size = new System.Drawing.Size(100, 23);
            this.largeplaceholder.TabIndex = 6;
            this.largeplaceholder.TabStop = false;
            this.largeplaceholder.UseSystemPasswordChar = false;
            // 
            // largekey
            // 
            this.largekey.Depth = 0;
            this.largekey.Hint = "";
            this.largekey.Location = new System.Drawing.Point(10, 9);
            this.largekey.MaxLength = 32767;
            this.largekey.MouseState = MaterialSkin.MouseState.HOVER;
            this.largekey.Name = "largekey";
            this.largekey.PasswordChar = '\0';
            this.largekey.SelectedText = "";
            this.largekey.SelectionLength = 0;
            this.largekey.SelectionStart = 0;
            this.largekey.Size = new System.Drawing.Size(100, 23);
            this.largekey.TabIndex = 6;
            this.largekey.TabStop = false;
            this.largekey.UseSystemPasswordChar = false;
            // 
            // time
            // 
            this.time.Depth = 0;
            this.time.Hint = "";
            this.time.Location = new System.Drawing.Point(150, 122);
            this.time.MaxLength = 32767;
            this.time.MouseState = MaterialSkin.MouseState.HOVER;
            this.time.Name = "time";
            this.time.PasswordChar = '\0';
            this.time.SelectedText = "";
            this.time.SelectionLength = 0;
            this.time.SelectionStart = 0;
            this.time.Size = new System.Drawing.Size(100, 23);
            this.time.TabIndex = 3;
            this.time.TabStop = false;
            this.time.Text = "0";
            this.toolTime.SetToolTip(this.time, "Enter time in seconds for to use the current time with an offset \r\nThe default of" +
        "fset is 0");
            this.time.UseSystemPasswordChar = false;
            // 
            // timetypebox
            // 
            this.timetypebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.timetypebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timetypebox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetypebox.ForeColor = System.Drawing.Color.White;
            this.timetypebox.FormattingEnabled = true;
            this.timetypebox.Items.AddRange(new object[] {
            "don\'t use the time",
            "elapsed",
            "left"});
            this.timetypebox.Location = new System.Drawing.Point(256, 122);
            this.timetypebox.Name = "timetypebox";
            this.timetypebox.Size = new System.Drawing.Size(110, 21);
            this.timetypebox.TabIndex = 2;
            this.timetypebox.SelectedIndexChanged += new System.EventHandler(this.Timetype_SelectedIndexChanged);
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savebtn.Depth = 0;
            this.savebtn.Icon = null;
            this.savebtn.Location = new System.Drawing.Point(281, 322);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.savebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.savebtn.Name = "savebtn";
            this.savebtn.Primary = false;
            this.savebtn.Size = new System.Drawing.Size(55, 36);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // revertbtn
            // 
            this.revertbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.revertbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.revertbtn.Depth = 0;
            this.revertbtn.Icon = null;
            this.revertbtn.Location = new System.Drawing.Point(344, 322);
            this.revertbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.revertbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.revertbtn.Name = "revertbtn";
            this.revertbtn.Primary = false;
            this.revertbtn.Size = new System.Drawing.Size(71, 36);
            this.revertbtn.TabIndex = 5;
            this.revertbtn.Text = "Revert";
            this.revertbtn.UseVisualStyleBackColor = true;
            this.revertbtn.Click += new System.EventHandler(this.Revertbtn_Click);
            // 
            // details
            // 
            this.details.Depth = 0;
            this.details.ForeColor = System.Drawing.SystemColors.Desktop;
            this.details.Hint = "";
            this.details.Location = new System.Drawing.Point(150, 42);
            this.details.MaxLength = 32767;
            this.details.MouseState = MaterialSkin.MouseState.HOVER;
            this.details.Name = "details";
            this.details.PasswordChar = '\0';
            this.details.SelectedText = "";
            this.details.SelectionLength = 0;
            this.details.SelectionStart = 0;
            this.details.Size = new System.Drawing.Size(100, 23);
            this.details.TabIndex = 6;
            this.details.TabStop = false;
            this.details.UseSystemPasswordChar = false;
            // 
            // state
            // 
            this.state.Depth = 0;
            this.state.Hint = "";
            this.state.Location = new System.Drawing.Point(150, 78);
            this.state.MaxLength = 32767;
            this.state.MouseState = MaterialSkin.MouseState.HOVER;
            this.state.Name = "state";
            this.state.PasswordChar = '\0';
            this.state.SelectedText = "";
            this.state.SelectionLength = 0;
            this.state.SelectionStart = 0;
            this.state.Size = new System.Drawing.Size(100, 23);
            this.state.TabIndex = 6;
            this.state.TabStop = false;
            this.state.UseSystemPasswordChar = false;
            // 
            // smallplaceholder
            // 
            this.smallplaceholder.Depth = 0;
            this.smallplaceholder.Hint = "";
            this.smallplaceholder.Location = new System.Drawing.Point(25, 105);
            this.smallplaceholder.MaxLength = 32767;
            this.smallplaceholder.MouseState = MaterialSkin.MouseState.HOVER;
            this.smallplaceholder.Name = "smallplaceholder";
            this.smallplaceholder.PasswordChar = '\0';
            this.smallplaceholder.SelectedText = "";
            this.smallplaceholder.SelectionLength = 0;
            this.smallplaceholder.SelectionStart = 0;
            this.smallplaceholder.Size = new System.Drawing.Size(100, 23);
            this.smallplaceholder.TabIndex = 6;
            this.smallplaceholder.TabStop = false;
            this.smallplaceholder.UseSystemPasswordChar = false;
            // 
            // btnfirsturl
            // 
            this.btnfirsturl.Depth = 0;
            this.btnfirsturl.Hint = "";
            this.btnfirsturl.Location = new System.Drawing.Point(13, 191);
            this.btnfirsturl.MaxLength = 32767;
            this.btnfirsturl.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnfirsturl.Name = "btnfirsturl";
            this.btnfirsturl.PasswordChar = '\0';
            this.btnfirsturl.SelectedText = "";
            this.btnfirsturl.SelectionLength = 0;
            this.btnfirsturl.SelectionStart = 0;
            this.btnfirsturl.Size = new System.Drawing.Size(171, 23);
            this.btnfirsturl.TabIndex = 7;
            this.btnfirsturl.TabStop = false;
            this.btnfirsturl.UseSystemPasswordChar = false;
            // 
            // btnfirsttext
            // 
            this.btnfirsttext.Depth = 0;
            this.btnfirsttext.Hint = "";
            this.btnfirsttext.Location = new System.Drawing.Point(190, 191);
            this.btnfirsttext.MaxLength = 32767;
            this.btnfirsttext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnfirsttext.Name = "btnfirsttext";
            this.btnfirsttext.PasswordChar = '\0';
            this.btnfirsttext.SelectedText = "";
            this.btnfirsttext.SelectionLength = 0;
            this.btnfirsttext.SelectionStart = 0;
            this.btnfirsttext.Size = new System.Drawing.Size(173, 23);
            this.btnfirsttext.TabIndex = 7;
            this.btnfirsttext.TabStop = false;
            this.btnfirsttext.UseSystemPasswordChar = false;
            // 
            // btnsecondurl
            // 
            this.btnsecondurl.Depth = 0;
            this.btnsecondurl.Hint = "";
            this.btnsecondurl.Location = new System.Drawing.Point(13, 237);
            this.btnsecondurl.MaxLength = 32767;
            this.btnsecondurl.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsecondurl.Name = "btnsecondurl";
            this.btnsecondurl.PasswordChar = '\0';
            this.btnsecondurl.SelectedText = "";
            this.btnsecondurl.SelectionLength = 0;
            this.btnsecondurl.SelectionStart = 0;
            this.btnsecondurl.Size = new System.Drawing.Size(171, 23);
            this.btnsecondurl.TabIndex = 7;
            this.btnsecondurl.TabStop = false;
            this.btnsecondurl.UseSystemPasswordChar = false;
            // 
            // btnsecondtext
            // 
            this.btnsecondtext.Depth = 0;
            this.btnsecondtext.Hint = "";
            this.btnsecondtext.Location = new System.Drawing.Point(190, 237);
            this.btnsecondtext.MaxLength = 32767;
            this.btnsecondtext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsecondtext.Name = "btnsecondtext";
            this.btnsecondtext.PasswordChar = '\0';
            this.btnsecondtext.SelectedText = "";
            this.btnsecondtext.SelectionLength = 0;
            this.btnsecondtext.SelectionStart = 0;
            this.btnsecondtext.Size = new System.Drawing.Size(173, 23);
            this.btnsecondtext.TabIndex = 7;
            this.btnsecondtext.TabStop = false;
            this.btnsecondtext.UseSystemPasswordChar = false;
            // 
            // randomlarge
            // 
            this.randomlarge.BackColor = System.Drawing.Color.Transparent;
            this.randomlarge.Depth = 0;
            this.randomlarge.Font = new System.Drawing.Font("Roboto", 10F);
            this.randomlarge.Location = new System.Drawing.Point(12, 281);
            this.randomlarge.Margin = new System.Windows.Forms.Padding(0);
            this.randomlarge.MouseLocation = new System.Drawing.Point(-1, -1);
            this.randomlarge.MouseState = MaterialSkin.MouseState.HOVER;
            this.randomlarge.Name = "randomlarge";
            this.randomlarge.Ripple = true;
            this.randomlarge.Size = new System.Drawing.Size(125, 17);
            this.randomlarge.TabIndex = 8;
            this.randomlarge.Text = "Random large";
            this.randomlarge.UseVisualStyleBackColor = false;
            this.randomlarge.CheckedChanged += new System.EventHandler(this.Randoms_CheckedChanged);
            // 
            // randomsmall
            // 
            this.randomsmall.BackColor = System.Drawing.Color.Transparent;
            this.randomsmall.Depth = 0;
            this.randomsmall.Font = new System.Drawing.Font("Roboto", 10F);
            this.randomsmall.Location = new System.Drawing.Point(13, 309);
            this.randomsmall.Margin = new System.Windows.Forms.Padding(0);
            this.randomsmall.MouseLocation = new System.Drawing.Point(-1, -1);
            this.randomsmall.MouseState = MaterialSkin.MouseState.HOVER;
            this.randomsmall.Name = "randomsmall";
            this.randomsmall.Ripple = true;
            this.randomsmall.Size = new System.Drawing.Size(124, 17);
            this.randomsmall.TabIndex = 8;
            this.randomsmall.Text = "Random small";
            this.randomsmall.UseVisualStyleBackColor = false;
            this.randomsmall.CheckedChanged += new System.EventHandler(this.Randoms_CheckedChanged);
            // 
            // globalbtns
            // 
            this.globalbtns.BackColor = System.Drawing.Color.Transparent;
            this.globalbtns.Depth = 0;
            this.globalbtns.Font = new System.Drawing.Font("Roboto", 10F);
            this.globalbtns.Location = new System.Drawing.Point(150, 281);
            this.globalbtns.Margin = new System.Windows.Forms.Padding(0);
            this.globalbtns.MouseLocation = new System.Drawing.Point(-1, -1);
            this.globalbtns.MouseState = MaterialSkin.MouseState.HOVER;
            this.globalbtns.Name = "globalbtns";
            this.globalbtns.Ripple = true;
            this.globalbtns.Size = new System.Drawing.Size(121, 17);
            this.globalbtns.TabIndex = 8;
            this.globalbtns.Text = "Global buttons";
            this.globalbtns.UseVisualStyleBackColor = false;
            this.globalbtns.CheckedChanged += new System.EventHandler(this.Globalbtns_CheckedChanged);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.deletebtn.Depth = 0;
            this.deletebtn.Icon = null;
            this.deletebtn.Location = new System.Drawing.Point(423, 322);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deletebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Primary = false;
            this.deletebtn.Size = new System.Drawing.Size(69, 36);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // globaltime
            // 
            this.globaltime.BackColor = System.Drawing.Color.Transparent;
            this.globaltime.Depth = 0;
            this.globaltime.Font = new System.Drawing.Font("Roboto", 10F);
            this.globaltime.Location = new System.Drawing.Point(150, 309);
            this.globaltime.Margin = new System.Windows.Forms.Padding(0);
            this.globaltime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.globaltime.MouseState = MaterialSkin.MouseState.HOVER;
            this.globaltime.Name = "globaltime";
            this.globaltime.Ripple = true;
            this.globaltime.Size = new System.Drawing.Size(121, 17);
            this.globaltime.TabIndex = 8;
            this.globaltime.Text = "Global time";
            this.globaltime.UseVisualStyleBackColor = false;
            this.globaltime.CheckedChanged += new System.EventHandler(this.Globalbtns_CheckedChanged);
            // 
            // ActivityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 364);
            this.ControlBox = false;
            this.Controls.Add(this.globaltime);
            this.Controls.Add(this.globalbtns);
            this.Controls.Add(this.randomsmall);
            this.Controls.Add(this.randomlarge);
            this.Controls.Add(this.btnsecondtext);
            this.Controls.Add(this.btnfirsttext);
            this.Controls.Add(this.btnsecondurl);
            this.Controls.Add(this.btnfirsturl);
            this.Controls.Add(this.state);
            this.Controls.Add(this.details);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.revertbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.time);
            this.Controls.Add(this.timetypebox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivityItem";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Revertbtn_Click);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField time;
        private System.Windows.Forms.ToolTip toolTime;
        private System.Windows.Forms.ComboBox timetypebox;
        private MaterialSkin.Controls.MaterialFlatButton savebtn;
        private MaterialSkin.Controls.MaterialFlatButton revertbtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField smallkey;
        private MaterialSkin.Controls.MaterialSingleLineTextField largekey;
        private MaterialSkin.Controls.MaterialSingleLineTextField details;
        private MaterialSkin.Controls.MaterialSingleLineTextField state;
        private MaterialSkin.Controls.MaterialSingleLineTextField largeplaceholder;
        private MaterialSkin.Controls.MaterialSingleLineTextField smallplaceholder;
        private MaterialSkin.Controls.MaterialSingleLineTextField btnfirsturl;
        private MaterialSkin.Controls.MaterialSingleLineTextField btnfirsttext;
        private MaterialSkin.Controls.MaterialSingleLineTextField btnsecondurl;
        private MaterialSkin.Controls.MaterialSingleLineTextField btnsecondtext;
        private MaterialSkin.Controls.MaterialCheckBox randomlarge;
        private MaterialSkin.Controls.MaterialCheckBox randomsmall;
        private MaterialSkin.Controls.MaterialCheckBox globalbtns;
        private MaterialSkin.Controls.MaterialFlatButton deletebtn;
        private MaterialSkin.Controls.MaterialCheckBox globaltime;
        
    }
}