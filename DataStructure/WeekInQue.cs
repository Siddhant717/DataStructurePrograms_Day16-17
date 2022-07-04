﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class WeekInQue
    {
        static Calender calender = new Calender();
        public static void DriverMethod()
        {
            WeekInQue w = new WeekInQue();
            Console.WriteLine("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            int[,] array = calender.calender(month, year);
            w.CalenderToQue(month, year);
            w.DisplayQueCalender(w.CalenderToQue(month, year));
        }
        public Queue<Object> CalenderToQue(int m, int y)
        {
            Queue<Object> res = new Queue<object>(7);
            string[] week_name = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Week[] obj = new Week[7];
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = new Week(week_name[i]);
            }

            int d = calender.DayOfWeek(1, m, y);
            int LastDate = calender.DaysInMonth(m);
            if (calender.IsLeapYear(y))
            {
                LastDate = 29;
            }
            int week_index = 0; int t = 0;
            for (int i = 0; i <= LastDate;)
            {
                if (i == 1)
                {
                    week_index = d;
                    obj[week_index++].list.Append(i);
                }
                else if (i != 1)
                {
                    obj[week_index++].list.Append(i);
                }
                if ((week_index > 6)) week_index = 0;
                if (t >= d - 1)
                {
                    i++;
                }
            }
            foreach (Object b in res)
            {
                res.Enqueue(b);
            }

            return res;
        }

        //Dispaly the Calender
        public void DisplayQueCalender(Queue<Object> obj)
        {
            for (int i = 0; i < 7; i++)
            {
                Week O = (Week)obj.Dequeue();
                int[] a = O.list.ToArray();
                Console.Write("{0,10}  ", O.week);
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == 0) Console.Write("{0,2} ", ' ');
                    else Console.Write("{0,2} ", a[j]);
                }
                Console.WriteLine();
            }

        }
    }
    public class Week
    {
        public string week;
        public List<int> list = new List<int>();
        public Week(string week)
        {
            this.week = week;
        }
        public override string ToString()
        {
            return this.week + " " + list;
        }
    }

}
