using MeetinGApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetinGApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            int saat= DateTime.Now.Hour;
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();


            var meetingInfo = new MeetingInfo() { 
            Id = 1,
            Location= "Istanbul, ZBS Kongre Merkezi",
            Date = new DateTime(2023,04,26,20,0,0),
            NumberOfPeople=UserCount,
            };
            return View(meetingInfo);
        }
    }
}
