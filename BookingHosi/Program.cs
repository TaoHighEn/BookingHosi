using OpenQA.Selenium; //安裝Selenium 新增
using OpenQA.Selenium.Chrome; //安裝Selenium Chrome新增
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;

namespace BookingHosi
{
    internal class Program
    {
        static bool flag = true;
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 1000;  //每分鐘
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(Booking);
            if (flag)
            {
                Console.ReadKey();
            }
            
            //Task.Run(() => {
            //    while (true)
            //    {
            //        Thread.Sleep(10000);
            //    }
            //});
        }
        public static void Booking(object source, ElapsedEventArgs e)
        {
            bool f = DateTime.Now.CompareTo()
            while ()
            {
                Console.WriteLine("Hello, World!");

                IWebDriver driver = new ChromeDriver();
                string str = "https://webreg.vghks.gov.tw/RSMKS/onlineReg";
                driver.Navigate().GoToUrl(str);
                //隱式等待 - 直到畫面跑出資料才往下執行
                string url = "https://webreg.vghks.gov.tw/RSMKS/api/myPost";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/json";
                string json = @"";
                //httpWebRequest.
            }
        }
    }
}