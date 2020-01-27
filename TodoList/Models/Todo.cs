using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
    public class Todo
    {
        [Key]
        public int TodoId { get; set; }
        public bool Completed { get; set; }
        public string Text { get; set; }
        
    }
}