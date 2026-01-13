namespace ResumeProjectDemo.ViewComponent.DefaultViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using ResumeProjectDemo.Context;

    public class _DefaultExperienceComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultExperienceComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }


    }
}
