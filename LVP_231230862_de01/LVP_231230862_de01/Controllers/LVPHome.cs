using System.Diagnostics;
using LVP_231230862_de01.Models;
using Microsoft.AspNetCore.Mvc;

namespace LVP_231230862_de01.Controllers
{
    public class LVPHome : Controller
    {
        private readonly ILogger<LVPHome> _logger;

        public LVPHome(ILogger<LVPHome> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
