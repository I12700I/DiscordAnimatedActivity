using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiscordAnimatedActivity.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void GlobalBtnsCheck_CheckedChanged(object sender, EventArgs e)
        {
            GlobalBtnsContainer.Enabled = GlobalBtnsCheck.Checked;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamWriter sw = new StreamWriter("settings.txt"))
                {
                    sw.WriteLine(ClientId.Text);
                    sw.WriteLine(TimeSleep.Text);
                    sw.WriteLine(LargeImages.Value);
                    sw.WriteLine(SmallImages.Value);
                    sw.WriteLine(AutoStart.Checked);
                    sw.WriteLine(AutoRandomImagesCheck.Checked);
                    sw.WriteLine(GlobalBtnsCheck.Checked);
                    sw.WriteLine(GlobalBtnFirstUrl.Text);
                    sw.WriteLine(GlobalBtnFirstText.Text);
                    sw.WriteLine(GlobalBtnSecondUrl.Text);
                    sw.WriteLine(GlobalBtnSecondText.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void RevertBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader sw = new StreamReader("settings.txt"))
            {
                ClientId.Text = sw.ReadLine();
                TimeSleep.Text = sw.ReadLine();
                LargeImages.Value = Convert.ToDecimal(sw.ReadLine());
                SmallImages.Value = Convert.ToDecimal(sw.ReadLine());
                AutoStart.Checked = Convert.ToBoolean(sw.ReadLine());
                AutoRandomImagesCheck.Checked = Convert.ToBoolean(sw.ReadLine());
                GlobalBtnsCheck.Checked = Convert.ToBoolean(sw.ReadLine());
                GlobalBtnFirstUrl.Text = sw.ReadLine();
                GlobalBtnFirstText.Text = sw.ReadLine();
                GlobalBtnSecondUrl.Text = sw.ReadLine();
                GlobalBtnSecondText.Text = sw.ReadLine();
            }
        }
    }
}
