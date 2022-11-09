using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string value = "132456799";
			int qq = value.Toint(0);




		}
	}

	public static class StringExtension
	{
		public static int Toint(this string source, int defaultValue)
		{
			bool isint = int.TryParse(source, out int number);
			return isint ? number : defaultValue;
		}

	     public static 
	
	
	
	}
}
