using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class Observer : IObserver
    {
        private ConcreteSubject subject;

        public Observer(ConcreteSubject concreteSubject)
        {
            this.subject = concreteSubject;
        }
        public void update()
        {
            string subjectState = subject.GetState();
            Console.WriteLine(subjectState);
        }
    }
}
