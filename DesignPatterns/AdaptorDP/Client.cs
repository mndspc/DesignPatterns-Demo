using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    class Client
    {
        static void Main()
        {
            ICustomer customer = new CustomerAdaptor();
            var customers = customer.GetCustomers();
            foreach(var cust in customers)
            {
                Console.WriteLine($"ID={cust.CustId}\t Name={cust.CustName}\t Email={cust.Email}");
            }

            var customerKyc = customer.GetKysDetails();
            foreach (var custKys in customerKyc)
            {
                Console.WriteLine($"Id={custKys.CustId}\t Adhaar={custKys.Adhaar}");
            }
            Console.ReadLine();
        }
    }
}
