using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BasicTodoList.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new ObservableCollection<ToDoItemViewModel>();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
        public partial string? NewItemContent { get; set; }

        /// <summary>
        /// Returns if a new Item can be added. We require to have the NewItem some Text
        /// </summary>
        private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewItemContent);

        /// <summary>
        /// This command is used to add a new Item to the List
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanAddItem))]
        private void AddItem()
        {
            // Add a new item to the list
            ToDoItems.Add(new ToDoItemViewModel() { Content = NewItemContent });

            // reset the NewItemContent
            NewItemContent = null;
        }

        /// <summary>
        /// Removes the given Item from the list
        /// </summary>
        /// <param name="item">the item to remove</param>
        [RelayCommand]
        private void RemoveItem(ToDoItemViewModel item)
        {
            // Remove the given item from the list
            ToDoItems.Remove(item);
        }
    }
}
