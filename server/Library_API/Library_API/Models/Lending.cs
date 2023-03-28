using System;
using System.Collections.Generic;

#nullable disable

namespace Library_API.Models
{
    public partial class Lending
    {
        public int? UserId { get; set; }
        public int? BookId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
