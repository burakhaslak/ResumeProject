

namespace ResumeProjectDemo.ViewComponent.DefaultViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
