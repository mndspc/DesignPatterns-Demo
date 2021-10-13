using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    interface IAggregate
    {
        IIterator GetIterator();
        string this[int index] { get; set; }
        int Count { get; }
    }
}
