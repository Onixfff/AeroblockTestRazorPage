using Aeroblock.DataAccess.Rail.Interface;
using Aeroblock.DataAccess.Rail.Repositories;
using AeroblockTestRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AeroblockTestRazorPage.Controllers
{
    public class ResettingSilosController : Controller
    {
        private readonly IResettingSilos _resettingSilos;

        private readonly ILogger<ResettingSilosController> _logger;

        public ResettingSilosController(ILogger <ResettingSilosController> logger, IResettingSilos resettingSilos) 
        {
            _resettingSilos = resettingSilos;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> GetTablePartial()
        {
            var result = await _resettingSilos.GetDataAsync();
            return PartialView("Table", result);
        }
    }
}
