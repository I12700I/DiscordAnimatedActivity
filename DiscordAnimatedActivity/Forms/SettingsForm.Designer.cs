namespace DiscordAnimatedActivity.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ClientId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LargeImages = new System.Windows.Forms.NumericUpDown();
            this.SmallImages = new System.Windows.Forms.NumericUpDown();
            this.AutoStart = new MaterialSkin.Controls.MaterialCheckBox();
            this.AutoRandomImagesCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.GlobalBtnsCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.GlobalBtnsContainer = new System.Windows.Forms.SplitContainer();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.GlobalBtnFirstText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.GlobalBtnFirstUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.GlobalBtnSecondText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.GlobalBtnSecondUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.SaveBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.RevertBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.TimeSleep = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalBtnsContainer)).BeginInit();
            this.GlobalBtnsContainer.Panel1.SuspendLayout();
            this.GlobalBtnsContainer.Panel2.SuspendLayout();
            this.GlobalBtnsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientId
            // 
            this.ClientId.Depth = 0;
            this.ClientId.Hint = "";
            this.ClientId.Location = new System.Drawing.Point(212, 77);
            this.ClientId.MaxLength = 32767;
            this.ClientId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClientId.Name = "ClientId";
            this.ClientId.PasswordChar = '\0';
            this.ClientId.SelectedText = "";
            this.ClientId.SelectionLength = 0;
            this.ClientId.SelectionStart = 0;
            this.ClientId.Size = new System.Drawing.Size(186, 23);
            this.ClientId.TabIndex = 0;
            this.ClientId.TabStop = false;
            this.ClientId.UseSystemPasswordChar = false;
            // 
            // LargeImages
            // 
            this.LargeImages.Location = new System.Drawing.Point(212, 130);
            this.LargeImages.Name = "LargeImages";
            this.LargeImages.Size = new System.Drawing.Size(185, 20);
            this.LargeImages.TabIndex = 1;
            // 
            // SmallImages
            // 
            this.SmallImages.Location = new System.Drawing.Point(212, 156);
            this.SmallImages.Name = "SmallImages";
            this.SmallImages.Size = new System.Drawing.Size(185, 20);
            this.SmallImages.TabIndex = 1;
            // 
            // AutoStart
            // 
            this.AutoStart.Depth = 0;
            this.AutoStart.Font = new System.Drawing.Font("Roboto", 10F);
            this.AutoStart.Location = new System.Drawing.Point(13, 181);
            this.AutoStart.Margin = new System.Windows.Forms.Padding(0);
            this.AutoStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AutoStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Ripple = true;
            this.AutoStart.Size = new System.Drawing.Size(90, 17);
            this.AutoStart.TabIndex = 2;
            this.AutoStart.Text = "Auto start";
            this.AutoStart.UseVisualStyleBackColor = true;
            // 
            // AutoRandomImagesCheck
            // 
            this.AutoRandomImagesCheck.Depth = 0;
            this.AutoRandomImagesCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.AutoRandomImagesCheck.Location = new System.Drawing.Point(110, 181);
            this.AutoRandomImagesCheck.Margin = new System.Windows.Forms.Padding(0);
            this.AutoRandomImagesCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AutoRandomImagesCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoRandomImagesCheck.Name = "AutoRandomImagesCheck";
            this.AutoRandomImagesCheck.Ripple = true;
            this.AutoRandomImagesCheck.Size = new System.Drawing.Size(159, 17);
            this.AutoRandomImagesCheck.TabIndex = 2;
            this.AutoRandomImagesCheck.Text = "Auto random images";
            this.AutoRandomImagesCheck.UseVisualStyleBackColor = true;
            // 
            // GlobalBtnsCheck
            // 
            this.GlobalBtnsCheck.Depth = 0;
            this.GlobalBtnsCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.GlobalBtnsCheck.Location = new System.Drawing.Point(278, 181);
            this.GlobalBtnsCheck.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalBtnsCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.GlobalBtnsCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.GlobalBtnsCheck.Name = "GlobalBtnsCheck";
            this.GlobalBtnsCheck.Ripple = true;
            this.GlobalBtnsCheck.Size = new System.Drawing.Size(119, 17);
            this.GlobalBtnsCheck.TabIndex = 2;
            this.GlobalBtnsCheck.Text = "Global buttons";
            this.GlobalBtnsCheck.UseVisualStyleBackColor = true;
            this.GlobalBtnsCheck.CheckedChanged += new System.EventHandler(this.GlobalBtnsCheck_CheckedChanged);
            // 
            // GlobalBtnsContainer
            // 
            this.GlobalBtnsContainer.Enabled = false;
            this.GlobalBtnsContainer.Location = new System.Drawing.Point(12, 216);
            this.GlobalBtnsContainer.Name = "GlobalBtnsContainer";
            this.GlobalBtnsContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // GlobalBtnsContainer.Panel1
            // 
            this.GlobalBtnsContainer.Panel1.Controls.Add(this.label2);
            this.GlobalBtnsContainer.Panel1.Controls.Add(this.label1);
            this.GlobalBtnsContainer.Panel1.Controls.Add(this.GlobalBtnFirstText);
            this.GlobalBtnsContainer.Panel1.Controls.Add(this.GlobalBtnFirstUrl);
            // 
            // GlobalBtnsContainer.Panel2
            // 
            this.GlobalBtnsContainer.Panel2.Controls.Add(this.label4);
            this.GlobalBtnsContainer.Panel2.Controls.Add(this.GlobalBtnSecondText);
            this.GlobalBtnsContainer.Panel2.Controls.Add(this.label3);
            this.GlobalBtnsContainer.Panel2.Controls.Add(this.GlobalBtnSecondUrl);
            this.GlobalBtnsContainer.Size = new System.Drawing.Size(385, 174);
            this.GlobalBtnsContainer.SplitterDistance = 80;
            this.GlobalBtnsContainer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // GlobalBtnFirstText
            // 
            this.GlobalBtnFirstText.Depth = 0;
            this.GlobalBtnFirstText.Hint = "";
            this.GlobalBtnFirstText.Location = new System.Drawing.Point(44, 39);
            this.GlobalBtnFirstText.MaxLength = 32767;
            this.GlobalBtnFirstText.MouseState = MaterialSkin.MouseState.HOVER;
            this.GlobalBtnFirstText.Name = "GlobalBtnFirstText";
            this.GlobalBtnFirstText.PasswordChar = '\0';
            this.GlobalBtnFirstText.SelectedText = "";
            this.GlobalBtnFirstText.SelectionLength = 0;
            this.GlobalBtnFirstText.SelectionStart = 0;
            this.GlobalBtnFirstText.Size = new System.Drawing.Size(326, 23);
            this.GlobalBtnFirstText.TabIndex = 0;
            this.GlobalBtnFirstText.TabStop = false;
            this.GlobalBtnFirstText.UseSystemPasswordChar = false;
            // 
            // GlobalBtnFirstUrl
            // 
            this.GlobalBtnFirstUrl.Depth = 0;
            this.GlobalBtnFirstUrl.Hint = "";
            this.GlobalBtnFirstUrl.Location = new System.Drawing.Point(44, 3);
            this.GlobalBtnFirstUrl.MaxLength = 32767;
            this.GlobalBtnFirstUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.GlobalBtnFirstUrl.Name = "GlobalBtnFirstUrl";
            this.GlobalBtnFirstUrl.PasswordChar = '\0';
            this.GlobalBtnFirstUrl.SelectedText = "";
            this.GlobalBtnFirstUrl.SelectionLength = 0;
            this.GlobalBtnFirstUrl.SelectionStart = 0;
            this.GlobalBtnFirstUrl.Size = new System.Drawing.Size(326, 23);
            this.GlobalBtnFirstUrl.TabIndex = 0;
            this.GlobalBtnFirstUrl.TabStop = false;
            this.GlobalBtnFirstUrl.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(0, 42);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Text";
            // 
            // GlobalBtnSecondText
            // 
            this.GlobalBtnSecondText.Depth = 0;
            this.GlobalBtnSecondText.Hint = "";
            this.GlobalBtnSecondText.Location = new System.Drawing.Point(44, 39);
            this.GlobalBtnSecondText.MaxLength = 32767;
            this.GlobalBtnSecondText.MouseState = MaterialSkin.MouseState.HOVER;
            this.GlobalBtnSecondText.Name = "GlobalBtnSecondText";
            this.GlobalBtnSecondText.PasswordChar = '\0';
            this.GlobalBtnSecondText.SelectedText = "";
            this.GlobalBtnSecondText.SelectionLength = 0;
            this.GlobalBtnSecondText.SelectionStart = 0;
            this.GlobalBtnSecondText.Size = new System.Drawing.Size(326, 23);
            this.GlobalBtnSecondText.TabIndex = 0;
            this.GlobalBtnSecondText.TabStop = false;
            this.GlobalBtnSecondText.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Url";
            // 
            // GlobalBtnSecondUrl
            // 
            this.GlobalBtnSecondUrl.Depth = 0;
            this.GlobalBtnSecondUrl.Hint = "";
            this.GlobalBtnSecondUrl.Location = new System.Drawing.Point(44, 3);
            this.GlobalBtnSecondUrl.MaxLength = 32767;
            this.GlobalBtnSecondUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.GlobalBtnSecondUrl.Name = "GlobalBtnSecondUrl";
            this.GlobalBtnSecondUrl.PasswordChar = '\0';
            this.GlobalBtnSecondUrl.SelectedText = "";
            this.GlobalBtnSecondUrl.SelectionLength = 0;
            this.GlobalBtnSecondUrl.SelectionStart = 0;
            this.GlobalBtnSecondUrl.Size = new System.Drawing.Size(326, 23);
            this.GlobalBtnSecondUrl.TabIndex = 0;
            this.GlobalBtnSecondUrl.TabStop = false;
            this.GlobalBtnSecondUrl.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Small images count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Large images count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sleep duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Client id";
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveBtn.Depth = 0;
            this.SaveBtn.Icon = null;
            this.SaveBtn.Location = new System.Drawing.Point(242, 408);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Primary = false;
            this.SaveBtn.Size = new System.Drawing.Size(55, 36);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RevertBtn
            // 
            this.RevertBtn.AutoSize = true;
            this.RevertBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RevertBtn.Depth = 0;
            this.RevertBtn.Icon = null;
            this.RevertBtn.Location = new System.Drawing.Point(326, 408);
            this.RevertBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RevertBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RevertBtn.Name = "RevertBtn";
            this.RevertBtn.Primary = false;
            this.RevertBtn.Size = new System.Drawing.Size(71, 36);
            this.RevertBtn.TabIndex = 4;
            this.RevertBtn.Text = "Revert";
            this.RevertBtn.UseVisualStyleBackColor = true;
            this.RevertBtn.Click += new System.EventHandler(this.RevertBtn_Click);
            // 
            // TimeSleep
            // 
            this.TimeSleep.Location = new System.Drawing.Point(213, 104);
            this.TimeSleep.Name = "TimeSleep";
            this.TimeSleep.Size = new System.Drawing.Size(185, 20);
            this.TimeSleep.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.ActionBarBound = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 453);
            this.Controls.Add(this.RevertBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.GlobalBtnsContainer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GlobalBtnsCheck);
            this.Controls.Add(this.AutoRandomImagesCheck);
            this.Controls.Add(this.AutoStart);
            this.Controls.Add(this.SmallImages);
            this.Controls.Add(this.TimeSleep);
            this.Controls.Add(this.LargeImages);
            this.Controls.Add(this.ClientId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.ShowTitle = true;
            this.StatusBarBound = true;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.RevertBtn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LargeImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallImages)).EndInit();
            this.GlobalBtnsContainer.Panel1.ResumeLayout(false);
            this.GlobalBtnsContainer.Panel1.PerformLayout();
            this.GlobalBtnsContainer.Panel2.ResumeLayout(false);
            this.GlobalBtnsContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalBtnsContainer)).EndInit();
            this.GlobalBtnsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeSleep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField ClientId;
        private System.Windows.Forms.NumericUpDown LargeImages;
        private System.Windows.Forms.NumericUpDown SmallImages;
        private MaterialSkin.Controls.MaterialCheckBox AutoStart;
        private MaterialSkin.Controls.MaterialCheckBox AutoRandomImagesCheck;
        private MaterialSkin.Controls.MaterialCheckBox GlobalBtnsCheck;
        private System.Windows.Forms.SplitContainer GlobalBtnsContainer;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField GlobalBtnFirstText;
        private MaterialSkin.Controls.MaterialSingleLineTextField GlobalBtnFirstUrl;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField GlobalBtnSecondText;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField GlobalBtnSecondUrl;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label8;
        private MaterialSkin.Controls.MaterialFlatButton SaveBtn;
        private MaterialSkin.Controls.MaterialFlatButton RevertBtn;
        private System.Windows.Forms.NumericUpDown TimeSleep;
    }
}