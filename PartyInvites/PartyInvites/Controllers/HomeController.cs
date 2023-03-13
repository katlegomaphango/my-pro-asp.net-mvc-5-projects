using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Afternoo";
            return View(); 
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: EMail response to party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
                
        }
    }
}