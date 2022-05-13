using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DiscordAnimatedActivity.Models
{
    static class Settings
    {
        public static string ClientId { get; set; }
        public static string TimeSleep { get; set; }
        public static decimal LargeImages { get; set; }
        public static decimal SmallImages { get; set; }
        public static bool AutoStart { get; set; }
        public static bool AutoRandomImagesCheck { get; set; }
        public static bool GlobalBtnsCheck { get; set; }
        public static string GlobalBtnFirstUrl { get; set; }
        public static string GlobalBtnFirstText { get; set; }
        public static string GlobalBtnSecondUrl { get; set; }
        public static string GlobalBtnSecondText { get; set; }

        public static void Write(string path)
        {
            try
            {

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(ClientId);
                    sw.WriteLine(TimeSleep);
                    sw.WriteLine(LargeImages);
                    sw.WriteLine(SmallImages);
                    sw.WriteLine(AutoStart);
                    sw.WriteLine(AutoRandomImagesCheck);
                    sw.WriteLine(GlobalBtnsCheck);
                    sw.WriteLine(GlobalBtnFirstUrl);
                    sw.WriteLine(GlobalBtnFirstText);
                    sw.WriteLine(GlobalBtnSecondUrl);
                    sw.WriteLine(GlobalBtnSecondText);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Revert(string path)
        {
            try
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    ClientId = sw.ReadLine();
                    TimeSleep = sw.ReadLine();
                    LargeImages = Convert.ToDecimal(sw.ReadLine());
                    SmallImages = Convert.ToDecimal(sw.ReadLine());
                    AutoStart = Convert.ToBoolean(sw.ReadLine());
                    AutoRandomImagesCheck = Convert.ToBoolean(sw.ReadLine());
                    GlobalBtnsCheck = Convert.ToBoolean(sw.ReadLine());
                    GlobalBtnFirstUrl = sw.ReadLine();
                    GlobalBtnFirstText = sw.ReadLine();
                    GlobalBtnSecondUrl = sw.ReadLine();
                    GlobalBtnSecondText = sw.ReadLine();
                }
            }
            catch (Exception)
            {
                ClientId = "";
                TimeSleep = "";
                LargeImages = 0;
                SmallImages = 0;
                AutoStart = false;
                AutoRandomImagesCheck = false;
                GlobalBtnsCheck = false;
                GlobalBtnFirstUrl = "";
                GlobalBtnFirstText = "";
                GlobalBtnSecondUrl = "";
                GlobalBtnSecondText = "";
            }
        }
    }
}
