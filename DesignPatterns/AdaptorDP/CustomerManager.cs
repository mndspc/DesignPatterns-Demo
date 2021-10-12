using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    // Adaptee
    class CustomerManager
    {
        public List<Customer> GetData()
        {
            List<Customer> customers = new List<Customer>
            {
            new Customer{CustId=100,CustName="Scott",Email="scott@gmail.com" },
              new Customer{CustId=101,CustName="Tiger",Email="tiger@gmail.com" },
                new Customer{CustId=102,CustName="Smith",Email="smith@gmail.com" },
            };
            return customers;
        }
        
    
    
    }
}
