using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KssAyncCodeWebConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many requests to issue?");
                int requests = Convert.ToInt32(Console.ReadLine());
                string syncPage = "http://localhost:50043/api/sync";
                string asyncPage = "http://localhost:50043/api/async";
                //DoHttpRequest(syncPage, requests);
                DoHttpRequest(asyncPage, requests);
            }
        }

        public static void DoHttpRequest(string page, int requests)
        {
            List<Task> asyncRequests = new List<Task>();

            using (HttpClient client = new HttpClient())
            {
                for(int i = 0; i < requests; i++)
                {
                    asyncRequests.Add(client.GetStringAsync(page));
                    Task<string> t = client.GetStringAsync(page);
                }

                Stopwatch sw = Stopwatch.StartNew();
                Task.WaitAll(asyncRequests.ToArray());
                sw.Stop();

                double requestsPerSecond = (1000 * requests) / sw.ElapsedMilliseconds;

                Console.WriteLine("Ran {0} requests in {1} ms; average of {2} per second", requests, sw.ElapsedMilliseconds, requestsPerSecond);
            }            
        }
    }
}
