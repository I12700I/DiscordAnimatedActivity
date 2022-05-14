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
        private List<TextBox> TextBoxes = new List<TextBox>();
        public main()
        {
            InitializeComponent();
            this.Controls.Add(FlowLayoutPanel);
            activities = db.activities.ToList();
            TextBox textBox = new TextBox();
            foreach (Activity activity in activities)
            {
                textBox.Text = activity.Details;
                TextBoxes.Add(textBox);
                FlowLayoutPanel.Container.Add(textBox);
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
