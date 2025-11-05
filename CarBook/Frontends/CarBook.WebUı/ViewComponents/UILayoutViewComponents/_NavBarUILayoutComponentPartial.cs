using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUı.ViewComponents.UILayoutViewComponents
{
    public class _NavBarUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
