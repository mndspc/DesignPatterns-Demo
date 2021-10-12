using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDP
{
    class KycManager
    {
        public List<CustomerKyc> GetData()
        {
            List<CustomerKyc> customerKycs = new List<CustomerKyc>
            {
                new CustomerKyc{CustId=100,Adhaar=21312312 },
                new CustomerKyc{CustId=101,Adhaar=435435 },
            };

            return customerKycs;
        }
    }
}
