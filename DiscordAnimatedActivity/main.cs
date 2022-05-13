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

namespace DiscordAnimatedActivity
{
    public partial class main : Form
    {
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
    }
}
