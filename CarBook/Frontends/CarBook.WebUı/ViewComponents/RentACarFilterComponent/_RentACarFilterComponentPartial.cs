using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUı.ViewComponents.RentACarFilterComponent
{
    public class _RentACarFilterComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke(string v)
        {
            TempData["value"] = v;
            return View();
        }
    }
}
