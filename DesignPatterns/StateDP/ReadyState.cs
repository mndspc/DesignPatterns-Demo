using System;
using System.Collections.Generic;
using System.Text;

namespace StateDP
{
    public class ReadyState : State
    {
        public ReadyState(State state)
        {
            currentState = "Ready State";
            nextState = "Printing State";
            printer = state.Printer;
            Initialize();
        }

        public ReadyState(Printer printer)
        {
            currentState = "Ready State";
            nextState = "Printing State";
            this.printer = printer;
            Initialize();
        }

        private void Initialize()
        {
            level = 0;
            StateChangeCheck();
        }

        public override void Cancel()
        {
            level = 2;
            StateChangeCheck();
        }

        public override void Ready()
        {
            level = 0;
            StateChangeCheck();
        }

        public override void Print()
        {
            level = 1;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            switch (level)
            {
                case 0:
                    printer.State = this;
                    break;
                case 1:
                    printer.State = new PrintingState(this);
                    break;
                case 2:
                    printer.State = new FinishState(this);
                    break;
            }
        }
    }
}
