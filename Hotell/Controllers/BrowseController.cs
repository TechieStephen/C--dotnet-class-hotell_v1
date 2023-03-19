using Hotell.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotell.Controllers
{
    public class BrowseController : Controller
    {
        public IActionResult Index()
        {
            //MVC
            ViewData["num"] = 20;
            var r1 = new Room();
            r1.RoomNo = 101;
            r1.Code = "Room_101";
            r1.Type = "Excutive";
            r1.Price = 25000.00;

            var r2 = new Room();
            r2.RoomNo = 102;
            r2.Code = "Room_102";
            r2.Type = "Standard";
            r2.Price = 15000.00;

            List<Room> rooms = new List<Room>();
            rooms.Add(r1);
            rooms.Add(r2);

            ViewData["rooms"] = rooms;
            return View();
        }
    }
}
