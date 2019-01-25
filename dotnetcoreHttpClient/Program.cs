using System;
using System.Net.Http;

namespace dotnetcoreHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient(new HttpClientHandler());
            //获取我们当前网站的dom
            var html = client.GetStringAsync("https://blog.csdn.net/qq_36051316/article/details/84872688").Result.ToString();
            Console.WriteLine("输出网站内容：");
            Console.WriteLine("================华丽分割线==================");
            System.Console.WriteLine(html);
        }
    }
}
