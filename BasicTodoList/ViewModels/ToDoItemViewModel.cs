using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTodoList.ViewModels
{
    public partial class ToDoItemViewModel : ViewModelBase
    {
        private bool _isChecked;

        public bool IsChecked
        {
            get { return _isChecked; }
            set { SetProperty(ref _isChecked, value); }
        }

        [ObservableProperty]
        public partial string? Content { get; set; }
    }
}
