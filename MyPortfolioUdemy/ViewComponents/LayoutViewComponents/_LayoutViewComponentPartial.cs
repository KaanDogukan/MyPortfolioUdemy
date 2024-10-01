using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutViewComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
