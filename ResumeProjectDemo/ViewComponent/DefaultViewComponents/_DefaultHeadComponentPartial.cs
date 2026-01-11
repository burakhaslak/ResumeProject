namespace ResumeProjectDemo.ViewComponent.DefaultViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
