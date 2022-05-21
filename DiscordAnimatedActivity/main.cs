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
using System.Threading;

namespace DiscordAnimatedActivity
{
    public partial class main : Form
    {
        private DiscordClient client = new DiscordClient();  
        private ApplicationContext db = new ApplicationContext();
        private List<ActivityItem> activityItems = new List<ActivityItem>();
        private Thread thread;
        private bool showActivity = false;
        public main()
        {
            InitializeComponent();
            Settings.Revert("settings.txt");
            foreach (Activity activity in db.activities.ToList())
            {
                activityItems.Add(new ActivityItem(activity) { Tag = activity.id,
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
            showActivity = true;
            thread = new Thread(new ThreadStart(RandomActivity));
            thread.Start();
        }
        private async void RandomActivity()
        {
            Random random = new Random();
            string btnfirsturl;
            string btnfirsttext;
            string btnsecondurl;
            string btnsecondtext;
            bool firstbtn;
            bool secondbtn;
            while (showActivity)
            {
                firstbtn = false;
                secondbtn = false;
                Activity activity = db.activities.ToList()[random.Next(0, db.activities.Count())];
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
                await Task.Delay((int)Settings.TimeSleep * 1000);
            }
        }
        private void stopTool_Click(object sender, EventArgs e)
        {
            showActivity = false;
            thread.Join();
            client.Deinitialize();
        }

        private void main_SizeChanged(object sender, EventArgs e)
        {
            foreach (ActivityItem item in activityItems)
            {
                item.Width = flowLayoutPanel1.ClientSize.Width - 8;
            }
        }

        private void addActivity_Click(object sender, EventArgs e)
        {
            Activity item = new Activity();
            db.activities.Add(item);
            db.SaveChanges();
            activityItems.Add(new ActivityItem(item)
            {
                Tag = item.id,
                TopLevel = false,
                Visible = true,
                Width = flowLayoutPanel1.ClientSize.Width - 25
            });
            flowLayoutPanel1.Controls.Add(activityItems.Last());
        }
    }
}
