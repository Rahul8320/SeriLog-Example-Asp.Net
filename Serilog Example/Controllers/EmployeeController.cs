using Microsoft.AspNetCore.Mvc;

namespace Serilog_Example.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
