namespace ResumeProjectDemo.ViewComponent.DefaultViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    public class _DefaultScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
