using AspNetCoreTodo.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Read the book about ASP .NET",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            var item2 = new TodoItem
            {
                Title = "Connect to git",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            return Task.FromResult(new[] { item1, item2 });

        }
    }
}
