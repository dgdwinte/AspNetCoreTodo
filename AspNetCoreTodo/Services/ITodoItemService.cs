using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsynch(ApplicationUser user);

        public Task<bool> AddItemAsync(TodoItem newItem, ApplicationUser user);

        public Task<bool> MarkDoneAsync(Guid id, ApplicationUser user);
    }
}
