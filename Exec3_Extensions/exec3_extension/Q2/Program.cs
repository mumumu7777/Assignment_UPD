using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string values1 = "87878787878";
			string values2 = "      1      ";

			string result = values1.GetStringLeftText(4);

			Console.WriteLine(result);


			string result2 = StringTool.NotnullOrEmpty(values1,5);
			Console.WriteLine(result2);


		}
	}

	public static class StringTool
	{

		public static string GetStringLeftText(this string sources, int length)
		{ 
			return sources.Substring(0, length);
		}
		public static string NotnullOrEmpty(this string sources ,int length)
		{
				
				if (string.IsNullOrEmpty(sources)) return string.Empty;
				if (length <= 0) return string.Empty;
				if (sources.Length <= 0) return sources;

				return sources.Substring(0, length);		
			
		 }
		



	}
}
