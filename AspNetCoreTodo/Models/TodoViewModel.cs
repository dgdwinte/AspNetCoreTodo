using Microsoft.AspNetCore.Mvc.RazorPages;
using System; 

namespace AspNetCoreTodo.Models
{
    public class TodoViewModel : PageModel
    {
        public TodoItem[] Items { get; set; }
    }
}
