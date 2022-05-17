using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordAnimatedActivity.Forms;
using DiscordAnimatedActivity.Models;

namespace DiscordAnimatedActivity
{
    public partial class main : Form
    {
        private DiscordClient client = new DiscordClient();  
        private ApplicationContext db = new ApplicationContext();
        private List<Activity> activities = new List<Activity>();
        private List<ActivityItem> activityItems = new List<ActivityItem>();
        public main()
        {
            InitializeComponent();
            Settings.Revert("settings.txt");
            activities = db.activities.ToList();
            foreach (Activity activity in activities)
            {
                activityItems.Add(new ActivityItem(activity) { Tag = activity.Id,
                                                               TopLevel = false, 
                                                               Visible = true,
                                                               Width = flowLayoutPanel1.ClientSize.Width - 25 });
                flowLayoutPanel1.Controls.Add(activityItems.Last());
            }
        }

        private void settingsTool_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.FormClosed += new FormClosedEventHandler(SettingsForm_FormClosed);
            this.Hide();
            settingsForm.Show();
        }
        void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            foreach (ActivityItem item in activityItems)
            {
                item.Revert();
            }
        }

        private void exitTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startTool_Click(object sender, EventArgs e)
        {
            try
            {
                client.Initialize();
            }
            catch (Exception)
            {
                MessageBox.Show("Check your settings!");
            }
            Random random = new Random();
            string btnfirsturl;
            string btnfirsttext;
            string btnsecondurl;
            string btnsecondtext;
            bool firstbtn = false;
            bool secondbtn = false;
            Activity activity = activities[random.Next(0, activities.Count)];
            if (activity.Isglobalbtns)
            {
                btnfirsturl = Settings.GlobalBtnFirstUrl;
                btnfirsttext = Settings.GlobalBtnFirstText;
                btnsecondurl = Settings.GlobalBtnSecondUrl;
                btnsecondtext = Settings.GlobalBtnSecondText;
                if (btnfirsturl != "" && btnfirsttext != "")
                {
                    firstbtn = true;
                    if (btnsecondurl != "" && btnsecondtext != "")
                    {
                        secondbtn = true;
                    }
                }
            }
            else
            {
                btnfirsturl = activity.Btnfirsturl;
                btnfirsttext = activity.Btnfirsttext;
                btnsecondurl = activity.Btnsecondurl;
                btnsecondtext = activity.Btnsecondtext;
                if (btnfirsturl != "" && btnfirsttext != "")
                {
                    firstbtn = true;
                    if (btnsecondurl != "" && btnsecondtext != "")
                    {
                        secondbtn = true;
                    }
                }
            }
            client.SetPresence(activity, firstbtn, secondbtn, btnfirsturl, btnfirsttext, btnsecondurl, btnsecondtext);
        }

        private void stopTool_Click(object sender, EventArgs e)
        {
            client.Deinitialize();
        }

        private void main_SizeChanged(object sender, EventArgs e)
        {
            foreach (ActivityItem item in activityItems)
            {
                item.Width = flowLayoutPanel1.ClientSize.Width - 8;
            }
        }
    }
}
