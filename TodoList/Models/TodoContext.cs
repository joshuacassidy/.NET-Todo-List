using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TodoList.Models;

namespace TodoList_Demo.Models
{

    public class TodoContext : DbContext
    {
        public TodoContext() : base("TodoContext")
        {

        }

        public DbSet<Todo> Todos { get; set; }

    }

}
