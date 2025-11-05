using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUı.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
