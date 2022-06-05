using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordAnimatedActivity.Forms;
using DiscordAnimatedActivity.Models;
using System.Threading;
using MaterialSkin.Controls;
using MaterialSkin;

namespace DiscordAnimatedActivity
{
    public partial class Main : MaterialForm
    {
        private readonly DiscordClient client = new DiscordClient();  
        private readonly ApplicationContext db = new ApplicationContext();
        private readonly List<ActivityItem> activityItems = new List<ActivityItem>();
        private Thread thread;
        private bool showActivity = false;
        
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            Settings.Revert("settings.txt");
            foreach (Activity activity in db.Activities.ToList())
            {
                ActivityItem activityItem = new ActivityItem(activity)
                {
                    Tag = activity.id,
                    TopLevel = false,
                    Visible = true,
                    Width = flowLayoutPanel1.ClientSize.Width - 25,
                };
                activityItems.Add(activityItem);
                flowLayoutPanel1.Controls.Add(activityItems.Last());
            }
            //
            // Change background color
            //
            this.toolsToolStripMenuItem.DropDown.BackColor = System.Drawing.Color.FromArgb(255, 51, 51, 51);
            this.activityToolStripMenuItem.DropDown.BackColor = System.Drawing.Color.FromArgb(255, 51, 51, 51);
            this.playToolStripMenuItem.DropDown.BackColor = System.Drawing.Color.FromArgb(255, 51, 51, 51);
        }

        private void SettingsTool_Click(object sender, EventArgs e)
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

        private void ExitTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartTool_Click(object sender, EventArgs e)
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
            DateTime globaltime = DateTime.UtcNow;
            while (showActivity)
            {
                firstbtn = false;
                secondbtn = false;
                Activity activity = db.Activities.ToList()[random.Next(0, db.Activities.Count())];
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
                client.SetPresence(activity, globaltime, firstbtn, secondbtn, btnfirsturl, btnfirsttext, btnsecondurl, btnsecondtext);
                await Task.Delay((int)Settings.TimeSleep * 1000);
            }
        }
        private void StopTool_Click(object sender, EventArgs e)
        {
            showActivity = false;
            thread.Join();
            client.Deinitialize();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            foreach (ActivityItem item in activityItems)
            {
                item.Width = flowLayoutPanel1.ClientSize.Width - 25;
            }
        }

        private void AddActivity_Click(object sender, EventArgs e)
        {
            Activity item = new Activity();
            db.Activities.Add(item);
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
