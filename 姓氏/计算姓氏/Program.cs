﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 计算姓氏;

namespace 计算姓氏
{
    class Program
    {
        static void Main(string[] args)
        {

            dd();
        
        }

        public static void dd()
        {
            var result = "";
            var day = 0;
            var Time = DateTime.Now;
            xingshi list = new xingshi();
            foreach (var item in list.InitialPersonList())
            {
                day = day + Math.Abs(((TimeSpan)(Time - item.Birthday)).Days);
            }

            var avgday = day / list.InitialPersonList().Count;
            var avgYears = avgday / 365;
            var avgDays = avgday - avgYears * 365;

            result = "平均年龄：" + avgYears + "周岁" + "-" + avgDays + "天";
            Console.WriteLine(result);
            GetName(list.InitialPersonList());
            Console.ReadLine();
        }
        public static void GetName(List<Person> persons)
        {
            var result1 = from i in persons
                          where i.Name.Contains("欧阳")
                          group i by i.Name.Substring(0, 2)
                              into g
                              select new { g.Key, sum = g.Count() };
            var result2 = from i in persons
                          where !i.Name.Contains("欧阳")
                          group i by i.Name.Substring(0, 1)
                              into g
                              select new { g.Key, sum = g.Count() };
            foreach (var x in result2)
            {
                Console.Write("姓氏：{0}\t{1}人\n", x.Key, x.sum);
            }
            foreach (var x in result1)
            {
                Console.Write("姓氏：{0}\t{1}人\n", x.Key, x.sum);
            }
        }
    }
}