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
        public main()
        {
            InitializeComponent();
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
