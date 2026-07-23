using BasicTodoList.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTodoList.ViewModels
{
    public partial class ToDoItemViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the checked status of each item
        /// </summary>
        // NOTE: This property is made without source generator. Uncomment the line below to use the source generator
        // [ObservableProperty]
        private bool _isChecked;

        public bool IsChecked
        {
            get { return _isChecked; }
            set { SetProperty(ref _isChecked, value); }
        }

        /// <summary>
        /// Gets or sets the content of the to-do item
        /// </summary>
        [ObservableProperty]
        public partial string? Content { get; set; }

        /// <summary>
        /// Creates a new blank ToDoItemViewModel
        /// </summary>
        public ToDoItemViewModel()
        {

        }

        /// <summary>
        /// Creates a new ToDoItemViewModel for the given <see cref="Models.ToDoItem"/>
        /// </summary>
        /// <param name="item">The item to load</param>
        public ToDoItemViewModel(ToDoItem item)
        {
            // Init the properties with the given values
            IsChecked = item.IsChecked;
            Content = item.Content;
        }

        /// <summary>
        /// Gets a ToDoItem of this ViewModel
        /// </summary>
        /// <returns>The ToDoItem</returns>
        public ToDoItem GetTodoItem()
        {
            return new ToDoItem()
            {
                IsChecked = this.IsChecked,
                Content = this.Content
            };
        }
    }
}
