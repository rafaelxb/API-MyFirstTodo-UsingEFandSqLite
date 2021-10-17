using System.ComponentModel.DataAnnotations;

namespace MyFirstTodo.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
