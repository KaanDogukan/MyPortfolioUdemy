using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDo(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTodoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTodoList(ToDoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangIsReadToTrue(int id)
        {
            var dgr = context.ToDoLists.Find(id);
            dgr.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var dgr = context.ToDoLists.Find(id);
            dgr.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
