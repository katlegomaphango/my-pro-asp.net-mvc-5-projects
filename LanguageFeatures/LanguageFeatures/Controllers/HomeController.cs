using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}