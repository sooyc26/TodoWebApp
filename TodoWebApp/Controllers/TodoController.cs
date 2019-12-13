using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWebApp.Models;

namespace TodoWebApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoListService _todoListService;

        public TodoController(ITodoListService t)
        {
            _todoListService = t;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new TodoListViewModel { List = _todoListService.GetList() };

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _todoListService.GetItem(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(TodoListItem item)
        {
            _todoListService.EditText(item.Id, item.Text);
            var model = new TodoListViewModel { List = _todoListService.GetList() };

            return View("Index", model);

        }
    }
}
