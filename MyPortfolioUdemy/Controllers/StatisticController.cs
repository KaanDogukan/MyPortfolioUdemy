using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            ViewBag.skl = context.Skills.Count(); 
            ViewBag.msg = context.Messages.Count();
            ViewBag.urmsg = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.rmsg = context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
