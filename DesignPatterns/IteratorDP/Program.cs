using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    class Program
    {
        static void Main()
        {
            Aggregate collection = new Aggregate();
            collection[0] = "String1";
            collection[1] = "String2";
            collection[2] = "String3";
            collection[3] = "String4";
            collection[4] = "String5";

            var iter = collection.GetIterator();
            string item = iter.FirstItem;

            while (!iter.IsDone)
            {
                Console.WriteLine(item);
                item = iter.NextItem;
            }

            Console.ReadLine();
        }
    }
}
