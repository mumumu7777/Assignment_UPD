using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 做法1
            Console.WriteLine("做法1\n");
            List<string> starList = new List<string>();
            List<string> spaceList = new List<string>();

            int star = 1;
            int layer = 10;

            for (int i = 0; i < layer; i++)
            {
                if (i != 0)
                {
                    star += 2;
                    starList.Add(new string('*', star));
                }
                else
                {
                    starList.Add(new string('*', star));
                }
            }

            for (int j = layer; j > 0; j--)
            {
                spaceList.Add(new string(' ', j));
            }

            for (int i = 0; i < layer; i++)
            {
                Console.WriteLine(spaceList[i] + starList[i]);
            }
            #endregion

            #region 做法2
            Console.WriteLine("\n做法2\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int a = 1; a <= 5 - i; a++)
                {
                    Console.Write(" ");
                }
                for (int b = 1; b < 2 * i; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

  
            Console.ReadKey();

        }
    }
}
