using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Q4表示日期字串"1100225" 轉成表示西元的日期20210225

			string day = "1100225";
			DateTime dada = Convert.ToDateTime(day);
			Console.WriteLine(dada);
		}
	}
}
