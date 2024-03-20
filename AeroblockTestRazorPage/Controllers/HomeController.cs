using Aeroblock.DataAccess.Rail.Interface;
using Aeroblock.DataAccess.Rail.Models;
using AeroblockTestRazorPage.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Web;

namespace AeroblockTestRazorPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMainPageRepository _mainPageRepository;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMainPageRepository mainPageRepository)
        {
            _logger = logger;
            _mainPageRepository = mainPageRepository;
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

        [HttpGet]
        public JsonResult GetName()
        {
            var names = new string[3]
            {
                "Clara",
                "marc",
                "Judy"
            };

            return new JsonResult(Ok(names));
        }

        [HttpPost]
        public JsonResult PostName(string name) 
        {
            return new JsonResult(Ok());
        }

        public IActionResult RedirectToOtherController()
        {
            return Json(new { redirectUrl = Url.Action("Index", "ResettingSilos") });
            return RedirectToAction("Index", "ResettingSilos");
            return RedirectToRoute(new {Controller = "ResettingSilos", action = "Index" });
        }

        public IActionResult GetModalWindow()
        {
            return PartialView("../Shared/Components/BigModal");
        }

        public async Task<IActionResult> GetTablePartial()
        {
            var result = await _mainPageRepository.GetAsync();
            return PartialView("TableMain", result);
        }
    }
}
