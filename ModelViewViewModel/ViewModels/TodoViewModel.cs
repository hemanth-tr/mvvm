using ModelViewViewModel.Models;
using ModelViewViewModel.Services;
using System.Windows.Input;

namespace ModelViewViewModel.ViewModels
{
    public class TodoViewModel
    {
        public Todo Todo { get; set; }
        private TodoService _todoService;
        public ICommand AddCommand { get; set; }

        public TodoViewModel()
        {
            _todoService = new TodoService();
            AddCommand = new RelayCommand((todo) => this.AddTodo((Todo)todo), (p) => true);
        }

        private void AddTodo(Todo todo) 
        {
            _todoService.AddTodo(todo);
        }
    }
}
