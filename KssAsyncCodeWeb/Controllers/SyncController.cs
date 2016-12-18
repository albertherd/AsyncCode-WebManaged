using KssAsyncCodeWeb.Data;
using KssAsyncCodeWeb.Data.Models;
using KssAsyncCodeWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KssAsyncCodeWeb.Controllers
{
    public class SyncController : ApiController
    {
        // GET: api/Sync
        public string Get()
        {
            IOWorker.DoIoWork();
            return "Done";
        }
    }
}
