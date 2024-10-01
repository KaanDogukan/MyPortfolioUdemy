using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            //var dgr = context.ToDoLists.Where(x => x.Status == false).ToList();
            //ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            //return View(dgr);
            return View();
        }


    }
}
