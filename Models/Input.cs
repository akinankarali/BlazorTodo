using System.ComponentModel.DataAnnotations;
namespace BlazorTodo.Models
{
    public class Input{
        [MinLength(3)]
        public string inputText { get; set; }
    }
}