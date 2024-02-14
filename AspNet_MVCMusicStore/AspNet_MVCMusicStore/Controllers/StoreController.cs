using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello from Store.Index() ";
        }
        [HttpGet]

        public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        [HttpGet]

        public string Details()
        {
            return "Hello from Store.Details()";
        }
        //
        // GET: /Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}
