using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //判斷某數是不是質數
            int sum = 0;
            int n = int.Parse(Console.ReadLine()); ;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += 1;
                }
            }
            if (sum == 2)
            {
                Console.WriteLine("n是質數");
            }
            else
            {
                Console.WriteLine("n不是質數");
            }

        }
	}
}
