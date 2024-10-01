using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateExperience(Experience exp)
        {
            context.Experiences.Add(exp);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }


        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value=context.Experiences.Find(id);
            return View("UpdateExperience",value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience ex)
        {
            context.Experiences.Update(ex);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }


    }
}
