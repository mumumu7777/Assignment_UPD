using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var items = Enumerable.Range(1, 10);
			
			foreach (var item in items)
			{
				Console.WriteLine(item);
			}

			var items2 = Enumerable.Range(10, 15);
			foreach (var item in items2)
			{
				Console.WriteLine(item);
			}



		}



	}
}
