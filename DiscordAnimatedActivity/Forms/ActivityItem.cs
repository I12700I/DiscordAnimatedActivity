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
        public ActivityItem(Activity activity)
        {
            InitializeComponent();
            id.Text = Convert.ToString(activity.Id);
            details.Text = activity.Details;
            state.Text = activity.State;
            largekey.Text = activity.Largeimagekey;
            largeplace.Text = activity.Largeimageplaceholder;
            smallkey.Text = activity.Smallimagekey;
            smallplace.Text = activity.Smallimageplaceholder;
        }
    }
}
