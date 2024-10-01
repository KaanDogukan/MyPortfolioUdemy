using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var msg = context.Messages.ToList();
			return View(msg);
		}

		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

		public IActionResult DeleteMessage(int id)
		{
			var msg = context.Messages.Find(id);
			context.Messages.Remove(msg);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult DetailMessage(int id)
		{
			var msg = context.Messages.Find(id);
			return View(msg);
		}


    }
}
