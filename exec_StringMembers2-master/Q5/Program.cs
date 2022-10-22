using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Q5對比輸入值是否為"Allen" 不分大小寫

			string answer = "Allen";
			Console.WriteLine("輸入Allen不分大小寫:");
			string input1 = Console.ReadLine();
			if (input1.ToLower() == answer.ToLower())
			{ Console.WriteLine("正確"); }

			else
			{ Console.WriteLine("錯誤"); }
			return;
		}
	}
}
