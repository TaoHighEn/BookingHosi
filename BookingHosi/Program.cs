using OpenQA.Selenium; //安裝Selenium 新增
using Select = OpenQA.Selenium.Support.UI.SelectElement;
using OpenQA.Selenium.Chrome; //安裝Selenium Chrome新增
using System.Net;
using System.Timers;


namespace BookingHosi
{
    internal class Program
    {
        static bool flag = true;
        static async Task Main(string[] args)
        {
            #region Timer
            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Enabled = true;
            //timer.Interval = 1000;  //每分鐘
            //timer.Start();
            //timer.Elapsed += new ElapsedEventHandler(Booking);
            //if (flag)
            //{
            //    Console.ReadKey();
            //}
            #endregion
            Task task = new Task(delegate { Booking(); });
            task.Start();
            await task;
            //Task.Run(() => {
            //    while (true)
            //    {
            //        Thread.Sleep(10000);
            //    }
            //});
        }
        public static async void Booking()
        {
            int i = DateTime.Now.CompareTo(DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd ") + "07:30:00"));
            while (i > 0)
            {
                flag = false;
                Console.WriteLine("Hello, World!");
                WebDriver drivers = new ChromeDriver();
                //IWebDriver driver = new ();
                string str = "https://webreg.vghks.gov.tw/RSMKS/onlineReg";
                drivers.Navigate().GoToUrl(str);
                //隱式等待 - 直到畫面跑出資料才往下執行

                //var elements = 
                //var elements = driver.FindElements(By.TagName("div"));
                var WebElements = drivers.FindElements(By.TagName("a"));
                WebElements.First(x => x.Text == "免疫風濕科").Click();
                drivers.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                WebElements = drivers.FindElements(By.TagName("select"));
                Select se = new Select(WebElements.First());
                se.SelectByValue("1");
                var result = drivers.FindElements(By.TagName("span"));
                //var items = result.FindElements(By.ClassName("ng-star-inserted"));
                //var items = result.Select.FindElements(By.TagName("span"));
                foreach (var item in result)
                {
                    var ii = item.GetType();
                    Console.WriteLine(item.Text);
                }
                
                //items.Click();
            }
        }
    }
}