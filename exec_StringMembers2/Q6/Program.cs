using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Q6比對輸入是否為"Allen區分大小寫

			string answer2 = "Allen";
			Console.WriteLine("輸入Allen分大小寫:");
			string input2 = Console.ReadLine();

			if (input2 == answer2)
			{ Console.WriteLine("正確"); }

			else
			{ Console.WriteLine("錯誤"); }

			if (input2.ToLower() == answer2.ToLower())

			{ Console.WriteLine("請確認大小寫"); }
			return;

		}
	}
}
