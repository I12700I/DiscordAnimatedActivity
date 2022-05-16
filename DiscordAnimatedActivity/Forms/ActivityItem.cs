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

namespace DiscordAnimatedActivity.Forms
{
    public partial class ActivityItem : Form
    {
        private string[] timetypes = { "None", "Elapsed", "Left" };
        private string timetype;
        private string activitytime;
        public ActivityItem(Activity activity)
        {
            InitializeComponent();
            details.Text = activity.Details;
            state.Text = activity.State;
            largekey.Text = activity.Largeimagekey;
            smallkey.Text = activity.Smallimagekey;
            toolLargeKey.SetToolTip(this.largekey, activity.Largeimageplaceholder);
            toolSmallKey.SetToolTip(this.smallkey, activity.Smallimageplaceholder);
            if (activity.Starttime != 0)
            {
                timetypebox.SelectedItem = timetypebox.Items[1];
                timetype = timetypes[1];
                time.Text = Convert.ToString(activity.Starttime);
            }
            else if (activity.Stoptime != 0)
            {
                timetypebox.SelectedItem = timetypebox.Items[2];
                timetype = timetypes[2];
                time.Text = Convert.ToString(activity.Stoptime);
            }
            else 
            { 
                timetypebox.SelectedItem = timetypebox.Items[0];
                timetype = timetypes[0];
                time.Enabled = false;
            }
        }

        private void timetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (timetypebox.SelectedIndex)
            {
                case 0:
                    timetype = timetypes[0];
                    time.Enabled = false;
                    break;
                case 1:
                    timetype = timetypes[1];
                    time.Enabled = true;
                    break;
                case 2:
                    timetype = timetypes[2];
                    time.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
