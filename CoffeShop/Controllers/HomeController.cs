using CoffeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace CoffeShop.Controllers
{
    public class HomeController : Controller
    {
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
        [Authorize(Roles = "Admin")]
        public IActionResult AdminOnly() => Content("หน้านี้ส ำหรับ Admin เท่านั้น");
        [Authorize(Roles = "Admin,Manager,Cashier")]
        public IActionResult StaffOnly() => Content($"พนักงาน: {User.Identity?.Name}");
    }
}
