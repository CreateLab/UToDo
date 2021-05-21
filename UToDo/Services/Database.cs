using System.Collections.Generic;
using UToDo.Models;

namespace UToDo.Services
{
    /// <summary>
    /// Представляет фейковую базу данных
    /// </summary>
    public class Database
    {
        public IEnumerable<TodoItem> GetItems() => new[]
        {
            new TodoItem {Description = "Walk"},
            new TodoItem {Description = "Buy some milk"},
            new TodoItem {Description = "CreateTodo", IsChecked = true}
        };
    }
}