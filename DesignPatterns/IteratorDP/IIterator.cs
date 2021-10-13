using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    interface IIterator
    {
        string FirstItem { get;}
        string NextItem { get; }

        string CurrentItem { get; }

        bool IsDone { get; }
    }
}
