using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRTuts.Hubs;
using SignalRTuts.Models;

namespace SignalRTuts.Controllers
{
    public class ServerController : Controller
    {
        
        private readonly IHubContext<NotificationHub> _notification;

        public ServerController(IHubContext<NotificationHub> notification)
        {
            _notification = notification;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.NumberOfClient = ConnectedUser.UserId.Count;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Notification model)
        {
            await _notification.Clients.All.SendAsync("ReceiveMsg", model.Message);
            return View();
        }
    }
}

