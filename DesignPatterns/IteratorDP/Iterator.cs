using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    class Iterator : IIterator
    {
        IAggregate aggregate = null;
        int currentIndex = 0;

        public Iterator(IAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public string FirstItem 
        {
            get
            {
                currentIndex = 0;
                return aggregate[currentIndex];
            }
        }

        public string NextItem
        {
            get
            {
                currentIndex += 1;

                if (IsDone == false)
                {
                    return aggregate[currentIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string CurrentItem 
        {
            get
            {
                return aggregate[currentIndex];
            }
        }


        public bool IsDone
        {
            get
            {
                if (currentIndex < aggregate.Count)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
