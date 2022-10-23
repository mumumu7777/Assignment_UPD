using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.121;
            double b = 1.23333;

            double res = Math.Round(a + b, 2,MidpointRounding.AwayFromZero);
           
            Console.WriteLine(res);


            Console.ReadLine();

        }
    }
}
