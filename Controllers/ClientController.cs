using Microsoft.AspNetCore.Mvc;

namespace SignalRTuts.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
