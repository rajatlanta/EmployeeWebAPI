using System;
using System.Collections.Generic;

namespace EmployeeWebAPI.Models1
{
    public partial class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? Price { get; set; }
    }
}
