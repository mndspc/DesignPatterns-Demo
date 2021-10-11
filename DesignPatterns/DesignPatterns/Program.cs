using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = num1 / num2;
                Console.WriteLine(result);

            }catch(Exception ex)
            {
                ExceptionHandler.Instance.WriteLog(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
