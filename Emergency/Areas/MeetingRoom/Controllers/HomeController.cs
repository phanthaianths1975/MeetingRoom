using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.MeetingRoom.Controllers
{
    [Area("MeetingRoom")]//Declare Area
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignIn(int id)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("MeetingRoom", "Scheduler", new { area = "MeetingRoom" });
            }
            //return RedirectToAction("error", "Home", new { area = "DarkSiteEmergency" });
            return View();
        }
    }
}
