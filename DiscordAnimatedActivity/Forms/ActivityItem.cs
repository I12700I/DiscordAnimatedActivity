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

        private Activity activity;
        public ActivityItem(Activity activity)
        {
            InitializeComponent();
            this.activity = activity;
            toolTime.SetToolTip(time, "Enter time in seconds for to use the current time with an offset \nThe default offset is 0");
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                activity.Details = details.Text;
                activity.State = state.Text;
                activity.Largeimagekey = largekey.Text;
                activity.Smallimagekey = smallkey.Text;
                if (timetype == timetypes[0])
                {
                    activity.Starttime = activity.Stoptime = 0;
                }
                else if (timetype == timetypes[1])
                {
                    activity.Starttime = Convert.ToInt32(time.Text);
                    activity.Stoptime = 0;
                }
                else
                {
                    activity.Stoptime = Convert.ToInt32(time.Text);
                    activity.Starttime = 0;
                }
                activity.Largeimageplaceholder = largeplaceholder.Text;
                activity.Smallimageplaceholder = smallplaceholder.Text;
                db.Entry(activity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void revertbtn_Click(object sender, EventArgs e)
        {
            details.Text = activity.Details;
            state.Text = activity.State;
            largekey.Text = activity.Largeimagekey;
            smallkey.Text = activity.Smallimagekey;
            largeplaceholder.Text = activity.Largeimageplaceholder;
            smallplaceholder.Text = activity.Smallimageplaceholder;
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
    }
}
