﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Calender
    {
        public static String[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        //Check for leap Year
        public bool IsLeapYear(int n)
        {
            if ((n % 400 == 0) || ((n % 100 != 0) && (n % 4 == 0)))
                return true;
            return false;
        }
        //Method for checking the Day of Week
        public int DayOfWeek(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }

        //Craeting the Calender
        public int[,] calender(int m, int y)
        {
            int[] days_in_month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear(y))
                days_in_month[2] = 29;

            int[,] res = new int[2, days_in_month[m] + 1];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 1; j < res.GetLength(1); j++)
                {
                    if (i == 0 && j <= 6) res[i, j] = j;
                    if (i == 1) res[i, j] = j;

                }
            }
            return res;
        }
        //Dispaly the Calender
        public void DisplayCalender(int m, int y)
        {

            char[] week = { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };

            int d = DayOfWeek(1, m, y);

            int[] days_in_month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(y))
            {
                days_in_month[2] = 29;
            }

            Console.WriteLine(months[m] + " " + y);

            for (int i = 0; i < week.Length; i++)
            {
                Console.Write(week[i] + "  ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < d; i++)
            {
                Console.Write("{0}  ", ' ');
            }

            for (int i = 1; i <= days_in_month[m]; i++)
            {
                Console.Write("{0,2} ", i);
                if ((i + d) % 7 == 0)
                {
                    Console.WriteLine("\n");
                }

            }
        }
        //Display the Month
        public int DaysInMonth(int m)
        {
            int[] days_in_month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return days_in_month[m];
        }

        public static void DriverMethod()
        {
            Calender c = new Calender();
            Console.Write("Enter month: "); int month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: "); int year = int.Parse(Console.ReadLine());
            Console.WriteLine("___________________________________________");
            c.DisplayCalender(month, year);
            Console.WriteLine("\n___________________________________________\n" +
                "Calender stored in 2D-Array");
            int[,] a = c.calender(month, year);
            c.DisplayArray(a);
            Console.WriteLine("__________________________________________________");
        }
        public void DisplayArray(int[,] a)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != 0 && j != 0) Console.Write(a[i, j] + " ");
                    if (i != 1 && j == 0) Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}