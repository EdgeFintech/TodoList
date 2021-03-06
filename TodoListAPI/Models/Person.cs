using JsonApiDotNetCore.Internal;
using JsonApiDotNetCore.Models;
using System.Collections.Generic;

namespace TodoListAPI.Models
{
    public class Person : Identifiable
    {
        [Attr("first-name")]
        public string FirstName { get; set; }
        [Attr("last-name")]
        public string LastName { get; set; }

        [HasMany("todo-items")]
        public virtual List<TodoItem> TodoItems { get; set; }
    }
}