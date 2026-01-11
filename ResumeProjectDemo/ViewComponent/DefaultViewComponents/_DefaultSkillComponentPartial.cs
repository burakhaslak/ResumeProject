namespace ResumeProjectDemo.ViewComponent.DefaultViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    public class _DefaultSkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
