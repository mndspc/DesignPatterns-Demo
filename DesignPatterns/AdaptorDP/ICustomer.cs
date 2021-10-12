using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    //  Target
    interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();

        IEnumerable<CustomerKyc> GetKysDetails();
    }
}
