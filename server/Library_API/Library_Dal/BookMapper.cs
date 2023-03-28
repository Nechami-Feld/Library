using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Library_Dal
{
    class BookMapper: MapperBase<Book>
    {
        protected override Book Map(IDataRecord record)
        {
            try
            {
                Book b = new Book();

                b.BookId = (DBNull.Value == record["BookID"]) ?
                    0 : (int)record["BookID"];
                b.BookName = (DBNull.Value == record["BookName"]) ?
                    string.Empty : (string)record["BookName"];
                b.BookAouther = (DBNull.Value == record["BookAouther"]) ?
                    string.Empty : (string)record["BookAouther"];
                b.NumberPages = (DBNull.Value == record["NumberPages"]) ?
                    0 : (int)record["NumberPages"];
                return b;
            }
            catch
            {
                throw;

                // NOTE: 
                // consider handling exeption here instead of re-throwing
                // if graceful recovery can be accomplished
            }
        }
    }
}
