using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTodoList.Models
{
    public class ToDoItem
    {
        /// <summary>
        /// Gets or sets the checked status of each item
        /// </summary>
        public bool IsChecked { get; set; }
        
        /// <summary>
        /// Gets or sets the content of each item
        /// </summary>
        public string? Content { get; set; }
    }
}
