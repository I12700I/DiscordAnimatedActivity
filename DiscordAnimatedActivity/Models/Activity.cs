using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordAnimatedActivity.Models
{
    public class Activity
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Details { get; set; }
        public string State { get; set; }
        public string Largeimagekey { get; set; }
        public string Largeimageplaceholder { get; set; }
        public string Smallimagekey { get; set; }
        public string Smallimageplaceholder { get; set; }
        public int Starttime { get; set; }
        public int Stoptime { get; set; }
        public string Btnfirsturl { get; set; }
        public string Btnfirsttext { get; set; }
        public string Btnsecondurl { get; set; }
        public string Btnsecondtext { get; set; }
        public bool Israndomlargeimages { get; set; }
        public bool Israndomsmallimages { get; set; }
        public bool Isglobalbtns { get; set; }
        public bool Isglobaltime { get; set; }
        public Activity() { }
        public Activity(string Details,
                        string State,
                        string Largeimagekey,
                        string Largeimageplaceholder,
                        string Smallimagekey,
                        string Smallimageplaceholder,
                        int Starttime,
                        int Stoptime,
                        string Btnfirsturl,
                        string Btnfirsttext,
                        string Btnsecondurl,
                        string Btnsecondtext,
                        bool Israndomlargeimages,
                        bool Israndomsmallimages,
                        bool Isglobalbtns,
                        bool Isglobaltime)
        {
            this.Details = Details;
            this.State = State;
            this.Largeimagekey = Largeimagekey;
            this.Largeimageplaceholder = Largeimageplaceholder;
            this.Smallimagekey = Smallimagekey;
            this.Smallimageplaceholder = Smallimageplaceholder;
            this.Starttime = Starttime;
            this.Stoptime = Stoptime;
            this.Btnfirsturl = Btnfirsturl;
            this.Btnfirsttext = Btnfirsttext;
            this.Btnsecondurl = Btnsecondurl;
            this.Btnsecondtext = Btnsecondtext;
            this.Israndomlargeimages = Israndomlargeimages;
            this.Israndomsmallimages = Israndomsmallimages;
            this.Isglobalbtns = Isglobalbtns;
            this.Isglobaltime = Isglobaltime;
        }
    }
}
