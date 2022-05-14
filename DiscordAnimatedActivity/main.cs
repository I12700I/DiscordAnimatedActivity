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
            //for (int i = 0; i < 5; i++)
            //{
            //    Button btn = new Button();
            //    btn.Name = "btn" + i;
            //    btn.Tag = i;
            //    btn.Text = i.ToString();
            //    btn.Font = new Font("Arial", 14f, FontStyle.Bold);
            //    // btn.UseCompatibleTextRendering = true;
            //    btn.BackColor = Color.Green;
            //    btn.Height = 57;
            //    btn.Width = 116;


            //    flowLayoutPanel1.Controls.Add(btn);

            //}
            activities = db.activities.ToList();
            foreach (Activity activity in activities)
            {
                activityItems.Add(new ActivityItem(activity) { Tag = activity.Id,
                                                               TopLevel = false, 
                                                               Visible = true,
                                                               Width = flowLayoutPanel1.ClientSize.Width-50});
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
            client.SetPresence();
        }

        private void stopTool_Click(object sender, EventArgs e)
        {
            client.Deinitialize();
        }
    }
}
