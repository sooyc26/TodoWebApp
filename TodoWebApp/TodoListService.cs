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
        TodoListItem GetItem(int id);
        bool EditText(int id, string text);
    }

    public class TodoListService : ITodoListService
    {
        private List<TodoListItem> _items;
        private readonly DateTime timeCounter = DateTime.UtcNow;
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

        public TodoListItem GetItem(int id)
        {
            return _items.First(x => x.Id == id);
        }

        public bool EditText(int id, string text)
        {
            foreach( var item in _items)
            {
                if (item.Id == id)
                {
                    item.Text = text;
                    item.IsEdited = true;
                    item.EditDate = DateTime.UtcNow;

                    return true;
                }
            }
            return false;
        }
    }
}
