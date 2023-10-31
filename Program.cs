using OpenQA.Selenium; //安裝Selenium 新增
using OpenQA.Selenium.Chrome; //安裝Selenium Chrome新增
using System.Net;

namespace BookingHosi
{
    internal class Program
    {
        static void Main(string[] args)
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