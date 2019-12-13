using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoWebApp.Interfaces;
using TodoWebApp.Models;

namespace TodoWebApp
{
    public class TodoListService : ITodoListService
    {
        private List<TodoListItem> _items;


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

            //ResetItems() executed after every 30min.
            var ResetTimer = new Timer(e =>
             {
                 ResetItems();
             }, null, TimeSpan.Zero, TimeSpan.FromMinutes(30));
        }

        /// <summary>
        /// Reset _items to original values
        /// </summary>
        private void ResetItems()
        {
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

        /// <summary>
        /// Returns single TodoListItem class by id.
        /// </summary>
        public TodoListItem GetItem(int id)
        {
            return _items.First(x => x.Id == id);
        }

        /// <summary>
        /// Edit TodoListItem from list.
        /// </summary>
        public void EditText(int id, string text)
        {
            foreach( var item in _items)
            {
                if (item.Id == id)  //update item when matching id found
                {
                    item.Text = text;
                    item.IsEdited = true;               
                    item.EditDate = DateTime.UtcNow;    //set time of edit

                    return;
                }
            }
        }
    }
}
