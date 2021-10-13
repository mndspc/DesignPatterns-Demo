using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new Observer(s));

            //  Change subject and notify observers
            s.SetState("Hello");

            Console.ReadLine();
        }
    }
}
