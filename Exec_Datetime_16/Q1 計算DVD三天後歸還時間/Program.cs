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


            Console.WriteLine("請輸入年分:");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime yeardayInput = new DateTime(year, 1, 1);
            DateTime yearday1 = new DateTime(year, 1, 1);
            DateTime yearday2 = new DateTime(year + 1, 1, 1);
            List<DateTime> sunList = new List<DateTime>();


            //int whileCount1 = 0;
            //while (yearday1 != yearday2 || yeardayInput == yearday1)
            //{
            //    whileCount1++;
            //    if ((int)yearday1.DayOfWeek == 0)
            //    {
            //        sunList.Add(yearday1);
            //    }

            //    yearday1 = yearday1.AddDays(1);
            //}
            //Console.WriteLine($"優化前迴圈次數{whileCount1}");

            // 優化 減少迴圈次數
            int whileCount2 = 0;
            while (yearday1 != yearday2 || yeardayInput == yearday1)
            {
                whileCount2++;
                if ((int)yearday1.DayOfWeek == 0)
                {
                    sunList.Add(yearday1);
                    yearday1 = yearday1.AddDays(7);
                }
                else
                {
                    yearday1 = yearday1.AddDays(1);
                }
            }

            // Linq  Foreach
            sunList.ForEach(item => Console.WriteLine($"{item.Date.ToString("yyyy/MM/dd")}"));
            Console.WriteLine($"優化後迴圈次數{whileCount2}");





            



            //Q6根據日期，傳回是本月的上旬，中旬，下旬

            int start2 = Convert.ToInt32(DateTime.Now.ToString("dd"));

            if (start2 <= 10)
            { Console.WriteLine("上旬"); }
            else if (start2 > 10 && start2 <= 20)

            { Console.WriteLine("中旬"); }

            else
            {
                Console.WriteLine("下旬");

                return;


                //}


                //Q7根據不同時間，傳回不同問安方式


                int start3 = Convert.ToInt32(DateTime.Now.ToString("HH"));

                if (start3 > 6 && start3 < 12)
                { Console.WriteLine("早安"); }
                else if (start3 >= 12 && start3 <= 18)

                { Console.WriteLine("午安"); }

                else
                {
                    Console.WriteLine("晚安");




                }



                Console.ReadKey();


            }
        }
    }
}