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
using MaterialSkin;
using MaterialSkin.Controls;

namespace DiscordAnimatedActivity.Forms
{
    public partial class ActivityItem : MaterialForm
    {
        private readonly string[] timetypes = { "None", "Elapsed", "Left" };
        private string timetype;
        private readonly Activity activity;
        public ActivityItem(Activity activity)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            this.activity = activity;
            toolTime.SetToolTip(time, "Enter time in seconds for to use the current time with an offset \nThe default offset is 0");
        }
        private void Timetype_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
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
                        if (globaltime.Checked) activity.Starttime++;
                    }
                    else
                    {
                        activity.Stoptime = Convert.ToInt32(time.Text);
                        activity.Starttime = 0;
                    }
                    activity.Largeimageplaceholder = largeplaceholder.Text;
                    activity.Smallimageplaceholder = smallplaceholder.Text;
                    activity.Israndomlargeimages = randomlarge.Checked;
                    activity.Israndomsmallimages = randomsmall.Checked;
                    activity.Isglobaltime = globaltime.Checked;
                    activity.Isglobalbtns = globalbtns.Checked;
                    activity.Btnfirsturl = btnfirsturl.Text;
                    activity.Btnfirsttext = btnfirsttext.Text;
                    activity.Btnsecondurl = btnsecondurl.Text;
                    activity.Btnsecondtext = btnsecondtext.Text;
                    db.Entry(activity).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check your settings!");
            }
        }
        private void Revertbtn_Click(object sender, EventArgs e)
        {
            randomlarge.Checked = activity.Israndomlargeimages;
            randomsmall.Checked = activity.Israndomsmallimages;
            globalbtns.Checked = activity.Isglobalbtns;
            globaltime.Checked = activity.Isglobaltime;
            SetBtns();
            SetImages();
            details.Text = activity.Details;
            state.Text = activity.State;
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
        private void SetImages()
        {
            largekey.Text = activity.Largeimagekey;
            smallkey.Text = activity.Smallimagekey;
            if (randomlarge.Checked)
            {
                largekey.Text = "Random";
            }
            if (randomsmall.Checked)
            {
                smallkey.Text = "Random";
            }
        }
        private void SetBtns()
        {
            if (globalbtns.Checked)
            {
                btnfirsturl.Enabled = btnfirsttext.Enabled = btnsecondurl.Enabled = btnsecondtext.Enabled = false;
                btnfirsturl.Text = Settings.GlobalBtnFirstUrl;
                btnfirsttext.Text = Settings.GlobalBtnFirstText;
                btnsecondurl.Text = Settings.GlobalBtnSecondUrl;
                btnsecondtext.Text = Settings.GlobalBtnSecondText;
            }
            else
            {
                btnfirsturl.Enabled = btnfirsttext.Enabled = btnsecondurl.Enabled = btnsecondtext.Enabled = true;
                btnfirsturl.Text = activity.Btnfirsturl;
                btnfirsttext.Text = activity.Btnfirsttext;
                btnsecondurl.Text = activity.Btnsecondurl;
                btnsecondtext.Text = activity.Btnsecondtext;
            }
        }
        public void Revert()
        {
            Revertbtn_Click(toolTime, EventArgs.Empty);
        }

        private void Globalbtns_CheckedChanged(object sender, EventArgs e)
        {
            SetBtns();
        }
        private void Randoms_CheckedChanged(object sender, EventArgs e)
        {
            SetImages();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Activities.Attach(activity);
                db.Activities.Remove(activity);
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
