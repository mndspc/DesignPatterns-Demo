using System;

namespace StateDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer("HP");

            printer.Ready();
            printer.Print();
            printer.Cancel();
            Console.ReadLine();
        }
    }
}
