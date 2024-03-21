using Aeroblock.DataAccess.Rail.Interface;
using Aeroblock.DataAccess.Rail.Repositories;
using AeroblockTestRazorPage.Interface;
using AeroblockTestRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AeroblockTestRazorPage.Controllers
{
    public class MoveSiloController : Controller, IGetModalWindow
    {

        private readonly IMoveSilo _moveSilo;

        private readonly ILogger<HomeController> _logger;

        public MoveSiloController(ILogger<HomeController> logger, IMoveSilo moveSilo)
        {
            _logger = logger;
            _moveSilo = moveSilo;
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

        public IActionResult GetModalWindow()
        {
            return PartialView("../Shared/Components/BigModal");
        }

        [HttpGet]
        public async Task<IActionResult> GetTablePartial()
        {
            var result = await _moveSilo.GetAsync();
            return PartialView("TableMoveSilo", result);
        }
    }
}
