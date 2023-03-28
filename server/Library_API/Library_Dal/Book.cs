using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Dal
{
    public class Book
    {
        #region Constructors

        public Book() { }

        #endregion

        #region Member Variables

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAouther { get; set; }
        public int? NumberPages { get; set; }

        #endregion

    }
}
