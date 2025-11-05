using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUı.ViewComponents.UILayoutViewComponents
{
    public class _ScriptCoverUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
