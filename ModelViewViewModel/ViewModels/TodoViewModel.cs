using ModelViewViewModel.Models;
using ModelViewViewModel.Services;
using ModelViewViewModel.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ModelViewViewModel.ViewModels
{
    public class TodoViewModel : BaseViewModel
    {
        public string TodoItem { get; set; }

        private TodoService _todoService;

        public ObservableCollection<Todo> TodoList {  get; set; }

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public TodoViewModel()
        {
            UserControl = nameof(TodoControl);
            _todoService = new TodoService();

            AddCommand = new RelayCommand(this.AddTodo, (p) => true);
            DeleteCommand = new RelayCommand(this.DeleteSelected, (p) => true);

            TodoItem = "hemanth";
            TodoList = [new Todo { Title = "Learn react" }];
        }

        private void AddTodo(object? parameter) 
        {
            var todo = new Todo { Title = this.TodoItem };
            _todoService.AddTodo(todo);
            TodoList.Add(todo);
        }

        private void DeleteSelected(object? parameter)
        {
            var x = 2;
        }
    }
}
