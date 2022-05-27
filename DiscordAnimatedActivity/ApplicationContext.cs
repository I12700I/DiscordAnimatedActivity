using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DiscordAnimatedActivity.Models;

namespace DiscordAnimatedActivity
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public ApplicationContext(): base("DefaultConnection") {}
    }
}
