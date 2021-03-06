using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordAnimatedActivity.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DiscordAnimatedActivity.Forms
{
    public partial class SettingsForm : MaterialForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void GlobalBtnsCheck_CheckedChanged(object sender, EventArgs e)
        {
            GlobalBtnsContainer.Enabled = GlobalBtnsCheck.Checked;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Settings.ClientId = ClientId.Text;
            Settings.TimeSleep = TimeSleep.Value;
            Settings.LargeImages = LargeImages.Value;
            Settings.SmallImages = SmallImages.Value;
            Settings.AutoStart = AutoStart.Checked;
            Settings.AutoRandomImagesCheck = AutoRandomImagesCheck.Checked;
            Settings.GlobalBtnsCheck = GlobalBtnsCheck.Checked;
            Settings.GlobalBtnFirstUrl = GlobalBtnFirstUrl.Text;
            Settings.GlobalBtnFirstText = GlobalBtnFirstText.Text;
            Settings.GlobalBtnSecondUrl = GlobalBtnSecondUrl.Text;
            Settings.GlobalBtnSecondText = GlobalBtnSecondText.Text;
            Settings.Write("settings.txt");
        }

        private void RevertBtn_Click(object sender, EventArgs e)
        {
            Settings.Revert("settings.txt");
            ClientId.Text = Settings.ClientId;
            TimeSleep.Value = Settings.TimeSleep;
            LargeImages.Value = Settings.LargeImages;
            SmallImages.Value = Settings.SmallImages;
            AutoStart.Checked = Settings.AutoStart;
            AutoRandomImagesCheck.Checked = Settings.AutoRandomImagesCheck;
            GlobalBtnsCheck.Checked = Settings.GlobalBtnsCheck;
            GlobalBtnFirstUrl.Text = Settings.GlobalBtnFirstUrl;
            GlobalBtnFirstText.Text = Settings.GlobalBtnFirstText;
            GlobalBtnSecondUrl.Text = Settings.GlobalBtnSecondUrl;
            GlobalBtnSecondText.Text = Settings.GlobalBtnSecondText;
        }
    }
}
