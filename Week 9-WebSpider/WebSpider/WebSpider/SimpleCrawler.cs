using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;



//改进书上例子9-10的爬虫程序。
// （1）优选爬取起始网站上的网页 
//（2）只有当爬取的是html文本时，才解析并爬取下一级URL。
// （3）相对地址转成绝对地址进行爬取。
//（4）尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。

namespace SimpleCrawler
{

    public class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        private int count = 0;
        public string startUrl;

        //static void Main(string[] args)
        //{
        //    SimpleCrawler myCrawler = new SimpleCrawler();
        //    myCrawler.Excute();
        //}
        public void Excute()
        {
            this.startUrl = "http://www.cnblogs.com/dstang2000/";
            //if (args.Length >= 1) myCrawler.startUrl = args[0];
            this.urls.Add(this.startUrl, false);//加入初始页面
            new Thread(this.Crawl).Start();
        }
        private void Crawl()
        {
            
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (!Regex.IsMatch(current, @"^(http[s]?://www.cnblogs.com/dstang2000)")) continue;
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");


                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Regex pthtml = new Regex(@"^(<!DOCTYPE\shtml>)");
                if (!pthtml.IsMatch(html))
                {
                    Console.WriteLine("爬行结束");
                    continue;
                }

                Parse(html,startUrl);//解析,并加入新的链接
                Console.WriteLine("爬行结束");

            }
        }


        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html,string startUrl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (Regex.IsMatch(strRef, @"^/"))//改为绝对地址
                {
                    strRef = startUrl.Substring(0,startUrl.Length-1) + strRef;
                }
                if (urls[strRef] == null) urls[strRef] = false;

            }
        }
    }
}
