using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_計算DVD三天後歸還時間
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q1_計算DVD三天後歸還時間
			DateTime start = DateTime.Now;

			DateTime end = start.AddDays(3);

			Console.WriteLine(end);

			//Q2 計算下個月圖書歸還時間

			DateTime bookreturn = start.AddMonths(1);
			Console.WriteLine(bookreturn);

			//Q3 取得本月一日
			DateTime Firstdayofmonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			Console.WriteLine(Firstdayofmonth);

			//Q4 本月最後一天   //下個月第一天-1

			DateTime lastdayofmonth = new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month, 1).AddDays(-1);
			Console.WriteLine(lastdayofmonth);

			//Q5列出指定的年份的每一個星期日

			//var starttime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			//var endtime = start.AddYears(1);
			//while (starttime < endtime)
			//{ if (starttime.DayOfWeek == endtime.DayOfWeek)

			//		Console.WriteLine(starttime)
			//			starttime = starttime.AddDays;
			//	;
			
			//	else
			//		start = start.AddDays(1)
			//}
			

			//Q6根據日期，傳回是本月的上旬，中旬，下旬
			
			int start2 = Convert.ToInt32(DateTime.Now.ToString("dd"));

			if (start2 <= 10)
			{ Console.WriteLine("上旬"); }
			else if (start2 > 10 && start2 <= 20)

			{ Console.WriteLine("中旬"); }

			else
			{
				Console.WriteLine("下旬");




			}


			//Q7根據不同時間，傳回不同問安方式


			int start3 = Convert.ToInt32(DateTime.Now.ToString("HH"));

			if (start3 >6 && start3<12)
			{ Console.WriteLine("早安"); }
			else if (start3 >=12  && start3 <=18 )

			{ Console.WriteLine("午安"); }

			else
			{
				Console.WriteLine("晚安");




			}






		}
	}
}
