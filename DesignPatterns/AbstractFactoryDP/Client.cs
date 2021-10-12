using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    class Client
    {
        private DbFactory dbFactory;

        public Client(DbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void CreateObj()
        {
            var connection = dbFactory.GetConnection();
            var command = dbFactory.GetCommand();

            command.CommandText = "select * from TableName";
            connection.Open();
            var reader= command.ExecuteReader();
            connection.Close();
        }
    }
}
