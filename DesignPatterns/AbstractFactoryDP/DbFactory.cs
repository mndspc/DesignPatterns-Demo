using System;
using System.Data.Common;
namespace AbstractFactoryDP
{
   
    abstract class DbFactory
    { 
        public abstract DbConnection GetConnection();

        public abstract DbCommand GetCommand();
    }
}
