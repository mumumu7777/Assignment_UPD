using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 倒三角
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int empty = 5 - i;
                int star = i;

                string starry = new string(' ', empty) + new string('*', star);
                Console.WriteLine(starry);

            }
        }
    }
}
