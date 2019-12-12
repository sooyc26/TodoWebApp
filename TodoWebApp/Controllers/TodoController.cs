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
        private readonly TodoListService _todoListService = new TodoListService();

        [HttpGet]
        public IActionResult Index()
        {
            var model = new TodoListViewModel { List = _todoListService.GetList() };

            return View(model);
        }
    }
}
