using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("請輸入手機號:");
			string inputph = Console.ReadLine();

			
		
			if (string.IsNullOrEmpty(inputph) || inputph.Length!=10)
			{ Console.WriteLine("請正確輸入手機號碼"); }

			string displayph = inputph.Substring(0,3)+ new string ('*',3)+ inputph.Substring(8,2);
			Console.WriteLine(displayph);
		}
	}
}
