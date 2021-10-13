using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class ConcreteSubject:Subject
    {
        private string state;

        public string GetState()
        {
            return state;
        }

        public void SetState(string newState)
        {
            state = newState;
            Notify();
        }
    }
}
