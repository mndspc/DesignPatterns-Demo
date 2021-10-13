using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    class Aggregate : IAggregate
    {
        List<string> values = null;

        public Aggregate()
        {
            values = new List<string>();
        }
        public string this[int index] 
        {
            get
            {
                if (index < values.Count)
                {
                    return values[index];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                values.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return values.Count;
            }
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }
    }
}
