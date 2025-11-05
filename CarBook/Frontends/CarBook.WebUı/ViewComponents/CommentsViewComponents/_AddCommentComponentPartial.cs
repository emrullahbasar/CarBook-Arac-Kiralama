using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUı.ViewComponents.CommentsViewComponents
{
    public class _AddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
