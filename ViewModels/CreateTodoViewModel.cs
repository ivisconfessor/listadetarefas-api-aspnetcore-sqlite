using System.ComponentModel.DataAnnotations;

namespace ListaTarefasAPI.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}