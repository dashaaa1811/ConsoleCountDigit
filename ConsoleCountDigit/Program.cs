﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCountDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(CountDigit(num));
        }

        static int CountDigit(int num)
        {
            int digitCount = 0;
            while (num > 0)
            {
                digitCount++;
                num /= 10;
            }
            return digitCount;

        }

    }
}