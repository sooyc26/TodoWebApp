using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWebApp.Models
{
    public class TodoListItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime EditDate { get; set; }  //private date created by auto property

        private bool edited;  //boolean edited field
        public bool IsEdited
        {
            get
            {
                return edited;
            }
            set
            {
                edited = value;
            }
        }
    }
}
