using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1將   abc   左右刪除

			//string value1 = "  abc  ";
			//string value2 = value1.Trim();
			//Console.WriteLine(value2);

			//Q2 將allen kou 轉成大寫

			string name1 = "allen kuo";
			string namebig = name1.ToUpper();
			Console.WriteLine(namebig);

			//Q3 將aLLen Kuo 轉成allen kuo

			string namea = "aLLen Kuo";
			string nameb = namea.ToLower();
			Console.WriteLine(nameb);

			//Q4表示日期字串"1100225" 轉成表示西元的日期20210225

			//string day = "1100225";
			//DateTime dada = Convert.ToDateTime(day);
			//Console.WriteLine(dada);

			//對比輸入值是否為"Allen" 不分大小寫

			string answer = "Allen";
			Console.WriteLine("輸入Allen不分大小寫:");
			string input1 = Console.ReadLine();
			if (input1.ToLower() == answer.ToLower())
			{ Console.WriteLine("正確"); }

			else
			{ Console.WriteLine("錯誤"); }
			return;
			//比對輸入是否為"Allen區分大小寫


			string answer2 = "Allen";
			Console.WriteLine("輸入Allen分大小寫:");
			string input2 = Console.ReadLine();

			if (input2 == answer2)
			{ Console.WriteLine("正確"); }

			else
			{ Console.WriteLine("錯誤"); }

			if (input2.ToLower() == answer2.ToLower())

			{ Console.WriteLine("請確認大小寫");}
			return;

		}
	}
}
