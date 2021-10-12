using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace AbstractFactoryDP
{
    class SqlServerFactory:DbFactory
    {
        SqlConnection sqlConnection;
        public override DbCommand GetCommand()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            return sqlCommand;
        }

        public override DbConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection("");
            this.sqlConnection = sqlConnection;
            return sqlConnection;
        }
    }
}
