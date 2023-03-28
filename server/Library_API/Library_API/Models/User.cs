using System;
using System.Collections.Generic;

#nullable disable

namespace Library_API.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
    }
}
