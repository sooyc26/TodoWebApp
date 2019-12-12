using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApp.Models;

namespace TodoWebApp
{
    public interface ITodoListService
    {
        List<TodoListItem> GetList();
    }

    public class TodoListService : ITodoListService
    {
        private readonly List<TodoListItem> _items;

        public TodoListService()
        {
            // Set the list items. This will reset every time the app is launched.
            _items = new List<TodoListItem> {
                new TodoListItem { Id = 1, Text = "Take out the trash" },
                new TodoListItem { Id = 2, Text = "Do the dishes" },
                new TodoListItem { Id = 3, Text = "Shop for holiday gifts" },
                new TodoListItem { Id = 4, Text = "Wash the car" },
                new TodoListItem { Id = 5, Text = "Complete dotnet core assignment" }
            };
        }

        /// <summary>
        /// Returns the list of items stored in memory.
        /// </summary>
        public List<TodoListItem> GetList() => _items;
    }
}
