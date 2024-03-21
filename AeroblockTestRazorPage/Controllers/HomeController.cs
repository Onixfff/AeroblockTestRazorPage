using Aeroblock.DataAccess.Rail.Interface;
using AeroblockTestRazorPage.Interface;
using AeroblockTestRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AeroblockTestRazorPage.Controllers
{
    public enum State�arriage
    {
        OnTheStation,
        OnTheWay,
        Unloaded,
        ForUnloading,
        All
    }

    public class HomeController : Controller, IGetModalWindow
    {
        private Dictionary<State�arriage, string> ruStateCarriage = new Dictionary<State�arriage, string> 
        {
            {State�arriage.All, "���" },
            {State�arriage.OnTheStation, "�� �������" },
            {State�arriage.OnTheWay, "� ����" },
            {State�arriage.Unloaded, "������������" },
            {State�arriage.ForUnloading, "�� ���������" }
        };

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
        public JsonResult GetState�arriage()
        {
            try
            {
                var enumValues = Enum.GetValues(typeof(State�arriage));
                var enumList = new List<string>();

                foreach (var ru in ruStateCarriage)
                {
                    foreach (State�arriage item in enumValues)
                    {
                        if(ru.Key == item)
                        {
                            enumList.Add(ru.Value);
                        }
                    }
                }

                return new JsonResult(enumList);
            }
            catch (Exception ex)
            {
                // ��������� ������, ���� ���-�� ����� �� ���
                return new JsonResult(new { status = "error", message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult PostName(string name) 
        {
            return new JsonResult(Ok());
        }

        public IActionResult RedirectToOtherController()
        {
            return Json(new { redirectUrl = Url.Action("Index", "ResettingSilos") });
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
