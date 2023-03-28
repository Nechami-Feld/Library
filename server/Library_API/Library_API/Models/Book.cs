using System;
using System.Collections.Generic;

#nullable disable

namespace Library_API.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAouther { get; set; }
        public int? NumberPages { get; set; }
    }
}
