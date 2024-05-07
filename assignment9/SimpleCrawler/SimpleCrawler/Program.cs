using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private List<Task> task;
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "https://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
            Console.ReadKey();
        }
        private void treeCrawl(List<string> Urls)
        {
            foreach (var current in Urls)
            {
                lock(this){
                    if (current == null || count > 14) break;
                    count++;
                }
                
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
             
                Parse(html, out List<string> url);//解析,并加入新的链接
                Console.WriteLine("爬行结束");

               
                    task.Add(Task.Run(() =>
                     {
                         treeCrawl(url);
                     }));
                


            }
            
            
        }
        private void Crawl()
        {
            task = new List<Task>();
            DateTime beforDT = System.DateTime.Now;
           List<string> Urls = new List<string>();
            foreach (string url in urls.Keys)
            {
                if ((bool)urls[url]) continue;
               Urls.Add(url);
            }
            treeCrawl(Urls);
            
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            Task.WaitAll(task.ToArray());
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);
          
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

        private void Parse(string html,out List<string> url)
        {
            url= new List<string>();
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) {
                    urls[strRef] = false;
                    url.Add(strRef);
                    }
            }
        }
    }
}
