using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Library_Dal
{
    abstract class ObjectReaderWithConnection<T> : ObjectReaderBase<T>
    {
        private static string m_connectionString = @"Data Source=Server=DESKTOP-57BCMEC; Database=Library; User ID=sa;Password=73490038;Initial Catalog=Test;Integrated Security=True";
        
        protected override System.Data.IDbConnection GetConnection()
        {
            // update to get your connection here

            IDbConnection connection = new  SqlConnection(m_connectionString);
            return connection;
        }
    }
}
