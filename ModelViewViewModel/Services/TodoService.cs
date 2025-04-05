using ModelViewViewModel.Models;

namespace ModelViewViewModel.Services
{
    public class TodoService
    {
        private List<Todo> Todos {  get; set; }

        public TodoService()
        {
            this.Todos = new List<Todo>();
        }

        public IEnumerable<Todo> GetTodos()
        {
            return this.Todos;
        }

        public void AddTodo(Todo todo)
        {
            ArgumentNullException.ThrowIfNull(todo, nameof(todo));
            ThrowIfExists(todo);

            this.Todos.Add(todo);
        }

        private void ThrowIfExists(Todo todo)
        {
            if (Todos.Any(x => x.Title.Equals(todo.Title, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception($"todo '{todo.Title}' exists.");
            }
        }
    }
}
