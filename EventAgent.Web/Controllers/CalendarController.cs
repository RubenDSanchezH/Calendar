using Microsoft.AspNetCore.Mvc;

namespace EventAgent.Web.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
