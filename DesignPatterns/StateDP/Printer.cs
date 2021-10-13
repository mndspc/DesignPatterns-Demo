using System;
using System.Collections.Generic;
using System.Text;

namespace StateDP
{
    public class Printer
    {
        private State state;
        private string name;

        public Printer(string name)
        {
            this.name = name;
            this.state = new ReadyState(this);
        }

        public string NextState
        {
            get { return state.NextState; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Ready()
        {
            state.Ready();
            Console.WriteLine($"Name: {name}, CurrentState:{state.CurrentState}, NextState:{state.NextState}");
        }
        public void Print()
        {
            state.Print();
            Console.WriteLine($"Name: {name}, CurrentState:{state.CurrentState}, NextState:{state.NextState}");
        }
        public void Cancel()
        {
            state.Cancel();
            Console.WriteLine($"Name: {name}, CurrentState:{state.CurrentState}, NextState:{state.NextState}");
        }
    }
}
