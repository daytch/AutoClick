using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Web;
using System.Timers;
using System.Text.RegularExpressions;

namespace UdemyProject
{
    public class OpenChrome
    {
        private string Url { get; set; }
        private int Min { get; set; }
        private int Max { get; set; }
        private int IDNow { get; set; }
        private int RangeTime { get; set; }
        private int index = 0;
        private string IDBefore;
        private string FirstTab;
        private Timer t = new Timer();
        private string FirstUrl = System.Configuration.ConfigurationSettings.AppSettings.Get("url").ToString();
        public ChromeDriver Driver { get; set; }

        public OpenChrome(string url, int min, int max, int idNow, int rangeTime)
        {
            this.Url = url;
            this.Min = min;
            this.Max = max;
            this.IDNow = idNow;
            this.RangeTime = rangeTime;
        }

        public void Open()
        {
            bool login = false;

            if (this.Driver == null)
            {
                //Hide chromedriver CMD
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                this.Driver = new ChromeDriver(service, options);

            }
        coba:
            try
            {
                this.Driver.Navigate().GoToUrl(FirstUrl);
                System.Threading.Thread.Sleep(1000);

                FirstTab = this.Driver.CurrentWindowHandle;
            }
            catch
            {
                ChromeOptions options = new ChromeOptions();
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                this.Driver = new ChromeDriver(options);
                goto coba;
            }
            //Session
            do
            {
                try
                {
                    login = this.Driver.FindElement(By.LinkText("Sign Out")).Displayed;
                }
                catch
                {
                    login = false;
                }
            } while (!login);

            t.Interval = RangeTime * 60 * 1000;
            t.Elapsed += NewTab;
            t.Start();
        }
        
        public void NewTab(object sender, ElapsedEventArgs e)
        {
            //Back to first tab and click Shop now
            this.Driver.SwitchTo().Window(FirstTab);
            this.Driver.FindElement(By.TagName("body")).SendKeys(Keys.Control + 1);
            this.Driver.FindElement(By.LinkText("SHOP NOW")).Click();

            IDBefore = String.Join(";", Regex.Matches(this.Url, @"\&OID=(.+?)\&").Cast<Match>().Select(m => m.Groups[1].Value));

            if (index == 0)
            {
                index = 1;
                this.Driver.ExecuteScript("window.open('', 'tab1');");
                this.Driver.SwitchTo().Window("tab1");

                this.Driver.Navigate().GoToUrl(Url);
            }
            else
            {
                index = index + 1;
                string tab = "tab" + index;
                string js = String.Format("window.open('', '{0}');", tab);
                Random rand = new Random();
                long val = (Min + rand.Next(0, (Max - Min) / 2) * 2) + 1;
                long after = val + Convert.ToInt64(IDBefore);
                this.Url = Url.Replace(IDBefore, after.ToString());
                this.Driver.ExecuteScript(js);
                this.Driver.SwitchTo().Window(tab);

                this.Driver.Navigate().GoToUrl(Url);
                //IDBefore = after.ToString();
            }
        }

        public void Stop()
        {
            t.Stop();
        }
    }
}
