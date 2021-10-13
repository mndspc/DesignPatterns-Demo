using System;
using System.Collections.Generic;
using System.Text;

namespace StateDP
{
    public abstract class State
    {
        protected Printer printer;
        protected string nextState;
        protected string currentState;
        protected int level;

        public Printer Printer
        {
            get { return printer; }
            set { printer = value; }
        }
        public string CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public string NextState
        {
            get { return nextState; }
            set { nextState = value; }
        }

        public abstract void Ready();
        public abstract void Print();
        public abstract void Cancel();
    }
}
