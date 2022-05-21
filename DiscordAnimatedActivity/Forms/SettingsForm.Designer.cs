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
            this.ClientId = new System.Windows.Forms.TextBox();
            this.LargeImages = new System.Windows.Forms.NumericUpDown();
            this.SmallImages = new System.Windows.Forms.NumericUpDown();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.AutoRandomImagesCheck = new System.Windows.Forms.CheckBox();
            this.GlobalBtnsCheck = new System.Windows.Forms.CheckBox();
            this.GlobalBtnsContainer = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GlobalBtnFirstText = new System.Windows.Forms.TextBox();
            this.GlobalBtnFirstUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GlobalBtnSecondText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GlobalBtnSecondUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RevertBtn = new System.Windows.Forms.Button();
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
            this.ClientId.Location = new System.Drawing.Point(118, 12);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(186, 20);
            this.ClientId.TabIndex = 0;
            // 
            // LargeImages
            // 
            this.LargeImages.Location = new System.Drawing.Point(118, 65);
            this.LargeImages.Name = "LargeImages";
            this.LargeImages.Size = new System.Drawing.Size(185, 20);
            this.LargeImages.TabIndex = 1;
            // 
            // SmallImages
            // 
            this.SmallImages.Location = new System.Drawing.Point(118, 91);
            this.SmallImages.Name = "SmallImages";
            this.SmallImages.Size = new System.Drawing.Size(185, 20);
            this.SmallImages.TabIndex = 1;
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.Location = new System.Drawing.Point(13, 119);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(71, 17);
            this.AutoStart.TabIndex = 2;
            this.AutoStart.Text = "Auto start";
            this.AutoStart.UseVisualStyleBackColor = true;
            // 
            // AutoRandomImagesCheck
            // 
            this.AutoRandomImagesCheck.AutoSize = true;
            this.AutoRandomImagesCheck.Location = new System.Drawing.Point(90, 119);
            this.AutoRandomImagesCheck.Name = "AutoRandomImagesCheck";
            this.AutoRandomImagesCheck.Size = new System.Drawing.Size(122, 17);
            this.AutoRandomImagesCheck.TabIndex = 2;
            this.AutoRandomImagesCheck.Text = "Auto random images";
            this.AutoRandomImagesCheck.UseVisualStyleBackColor = true;
            // 
            // GlobalBtnsCheck
            // 
            this.GlobalBtnsCheck.AutoSize = true;
            this.GlobalBtnsCheck.Location = new System.Drawing.Point(210, 119);
            this.GlobalBtnsCheck.Name = "GlobalBtnsCheck";
            this.GlobalBtnsCheck.Size = new System.Drawing.Size(94, 17);
            this.GlobalBtnsCheck.TabIndex = 2;
            this.GlobalBtnsCheck.Text = "Global buttons";
            this.GlobalBtnsCheck.UseVisualStyleBackColor = true;
            this.GlobalBtnsCheck.CheckedChanged += new System.EventHandler(this.GlobalBtnsCheck_CheckedChanged);
            // 
            // GlobalBtnsContainer
            // 
            this.GlobalBtnsContainer.Enabled = false;
            this.GlobalBtnsContainer.Location = new System.Drawing.Point(12, 154);
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
            this.GlobalBtnsContainer.Size = new System.Drawing.Size(291, 174);
            this.GlobalBtnsContainer.SplitterDistance = 80;
            this.GlobalBtnsContainer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // GlobalBtnFirstText
            // 
            this.GlobalBtnFirstText.Location = new System.Drawing.Point(34, 39);
            this.GlobalBtnFirstText.Name = "GlobalBtnFirstText";
            this.GlobalBtnFirstText.Size = new System.Drawing.Size(251, 20);
            this.GlobalBtnFirstText.TabIndex = 0;
            // 
            // GlobalBtnFirstUrl
            // 
            this.GlobalBtnFirstUrl.Location = new System.Drawing.Point(34, 3);
            this.GlobalBtnFirstUrl.Name = "GlobalBtnFirstUrl";
            this.GlobalBtnFirstUrl.Size = new System.Drawing.Size(251, 20);
            this.GlobalBtnFirstUrl.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Text";
            // 
            // GlobalBtnSecondText
            // 
            this.GlobalBtnSecondText.Location = new System.Drawing.Point(34, 39);
            this.GlobalBtnSecondText.Name = "GlobalBtnSecondText";
            this.GlobalBtnSecondText.Size = new System.Drawing.Size(251, 20);
            this.GlobalBtnSecondText.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Url";
            // 
            // GlobalBtnSecondUrl
            // 
            this.GlobalBtnSecondUrl.Location = new System.Drawing.Point(34, 3);
            this.GlobalBtnSecondUrl.Name = "GlobalBtnSecondUrl";
            this.GlobalBtnSecondUrl.Size = new System.Drawing.Size(251, 20);
            this.GlobalBtnSecondUrl.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Small images count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Large images count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sleep duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Client id";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(15, 346);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(141, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RevertBtn
            // 
            this.RevertBtn.Location = new System.Drawing.Point(161, 346);
            this.RevertBtn.Name = "RevertBtn";
            this.RevertBtn.Size = new System.Drawing.Size(141, 23);
            this.RevertBtn.TabIndex = 4;
            this.RevertBtn.Text = "Revert";
            this.RevertBtn.UseVisualStyleBackColor = true;
            this.RevertBtn.Click += new System.EventHandler(this.RevertBtn_Click);
            // 
            // TimeSleep
            // 
            this.TimeSleep.Location = new System.Drawing.Point(119, 39);
            this.TimeSleep.Name = "TimeSleep";
            this.TimeSleep.Size = new System.Drawing.Size(185, 20);
            this.TimeSleep.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 392);
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
            this.Text = "SettingsForm";
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

        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.NumericUpDown LargeImages;
        private System.Windows.Forms.NumericUpDown SmallImages;
        private System.Windows.Forms.CheckBox AutoStart;
        private System.Windows.Forms.CheckBox AutoRandomImagesCheck;
        private System.Windows.Forms.CheckBox GlobalBtnsCheck;
        private System.Windows.Forms.SplitContainer GlobalBtnsContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GlobalBtnFirstText;
        private System.Windows.Forms.TextBox GlobalBtnFirstUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GlobalBtnSecondText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GlobalBtnSecondUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button RevertBtn;
        private System.Windows.Forms.NumericUpDown TimeSleep;
    }
}