using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace KssAsyncCodeWeb.Logic
{
    public class IOWorker
    {
        public static async Task DoIoWorkAsync()
        {
            await DoIoWorkImpl();
        }

        public static void DoIoWork()
        {
            DoIoWorkImpl().Wait();
        }

        private static Task DoIoWorkImpl()
        {
            return Task.Delay(250);
        }
    }
}