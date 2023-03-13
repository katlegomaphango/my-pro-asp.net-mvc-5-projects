using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a url to show an example";
        }

    }
}