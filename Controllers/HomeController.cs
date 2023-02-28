using Microsoft.AspNetCore.Mvc;
using NetcoreInventory.Models;
using System.Diagnostics;

namespace NetcoreInventory.Controllers
{
    public class HomeController : Controller
    {

        // ทดสอบเขียนฟังก์ชันการเชื่อมต่อ Database
        public string TestConnectDB()
        {
            // สร้าง object context
            InventoryDBContext dBContext = new InventoryDBContext();
            if (dBContext.Database.CanConnect())
            {
                return "Connect Database Success";
            }
            else
            {
                return "Connect Database Fail!!";
            }
        }

        [HttpGet]
        public PartialViewResult GetPartialView()
        {
            return PartialView("_MyPartialView");
        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
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