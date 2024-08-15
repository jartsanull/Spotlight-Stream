using Microsoft.AspNetCore.Mvc;
using Spotlight_Stream.Models;
using System.Diagnostics;

namespace Spotlight_Stream.Controllers
{
    public class SpotlightController : Controller
    {
        private readonly ILogger<SpotlightController> _logger;

        public SpotlightController(ILogger<SpotlightController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
