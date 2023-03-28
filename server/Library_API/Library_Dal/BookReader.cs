using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Library_Dal
{
    class BookReader: ObjectReaderWithConnection<Book>
    {
        protected override string CommandText
        {
            get { return "SELECT PersonID, FirstName, LastName, Email FROM tblPerson"; }
        }

        protected override CommandType CommandType
        {
            get { return System.Data.CommandType.Text; }
        }

        protected override Collection<IDataParameter> GetParameters(IDbCommand command)
        {
            Collection<IDataParameter> collection = new Collection<IDataParameter>();
            return collection;

            //// USE THIS IF YOU ACTUALLY HAVE PARAMETERS
            //IDataParameter param1 = command.CreateParameter();
            //param1.ParameterName = "paramName 1"; // put parameter name here
            //param1.Value = 5; // put value here;

            //collection.Add(param1);

            //return collection;   
        }

        protected override MapperBase<Book> GetMapper()
        {
            MapperBase<Book> mapper = new BookMapper();
            return mapper;
        }
    }
}
