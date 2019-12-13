using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApp.Models;

namespace TodoWebApp.Interfaces
{
    public interface ITodoListService
    {
        List<TodoListItem> GetList();
        TodoListItem GetItem(int id);
        bool EditText(int id, string text);
    }
}
