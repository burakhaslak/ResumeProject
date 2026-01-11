

namespace ResumeProjectDemo.ViewComponent.DefaultViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    public class _DefaultExperienceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
