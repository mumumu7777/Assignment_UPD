using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec3_extension
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1

			bool result = MyMath.IsEvan(55);
			bool result2 = 5025.IsOdd();

			Console.WriteLine(result);
			Console.WriteLine(result2);

		}
	}


	public static class MyMath
	{
		public static bool IsEvan(this int source)
		{
			return source % 2 == 0;
		}

		public static bool IsOdd(this int source)
		{
			return source % 2 != 0;
		}

	}
}
