using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
   
    class CustomerAdaptor:ICustomer
    {
        CustomerManager customerManager = new CustomerManager();
        KycManager kycManager = new KycManager();
        public IEnumerable<Customer> GetCustomers()
        {
            var customers = customerManager.GetData();
            return customers;
        }

        public IEnumerable<CustomerKyc> GetKysDetails()
        {
            var customerKyc = kycManager.GetData();
            return customerKyc;
        }
    }
}
