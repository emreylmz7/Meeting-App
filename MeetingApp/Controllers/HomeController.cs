using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.AddControllersWithViews
{
    public class HomeController:Controller {
        public IActionResult Index()
        {
            int time = DateTime.Now.Hour;

            ViewData["Greeting"] =  time > 12 ? "Have a Nice Day":"Good Morning";
            int UserCount = Repository.Users.Where(i=> i.WillAttend == true).Count();
            // ViewData["UserName"] = "Emre";

            var meetingInfo = new MeetingInfo() {
                Id = 1,
                Location = "Antalya, SD Kongre Merkezi",
                Date = new DateTime(2024,01,20, 20,0,0),
                NumberOfPeople = UserCount

            };
            return View(meetingInfo); 
        }
    }

}