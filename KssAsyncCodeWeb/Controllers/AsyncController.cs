using KssAsyncCodeWeb.Logic;
using System.Threading.Tasks;
using System.Web.Http;

namespace KssAsyncCodeWeb.Controllers
{
    public class AsyncController : ApiController
    {
        // GET: api/Async
        public async Task<string> Get()
        {
            await IOWorker.DoIoWorkAsync();
            return "Done";
        }
    }
}
