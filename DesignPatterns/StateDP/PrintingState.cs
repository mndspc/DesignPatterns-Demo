using System;
using System.Collections.Generic;
using System.Text;

namespace StateDP
{
    public class PrintingState: State
    {
        public PrintingState(State state)
        {
            currentState = "Print State";
            this.nextState = "Finish State";
            this.printer = state.Printer;
            Initialize();
        }

        private void Initialize()
        {
            level = 1;
        }

        public override void Print()
        {
            level = 1;
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

        private void StateChangeCheck()
        {
            switch (level)
            {
                case 0:
                    printer.State = new ReadyState(this);
                    break;
                case 1:
                    printer.State = this;
                    break;
                case 2:
                    printer.State = new FinishState(this);
                    break;
            }
        }
    }
}
