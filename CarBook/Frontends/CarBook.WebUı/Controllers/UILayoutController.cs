using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUı.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
