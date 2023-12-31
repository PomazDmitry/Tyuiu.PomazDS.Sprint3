﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task0.V18.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint3.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3,"Оператор цикла for", 0, 18, "Написать программу используя цикл for, которая вычисляет произведение ряда по формуле, при X=1", "x=1, k=1 to 6");

            int value = 1;
            int startValue = 1;
            int stopValue = 6;

            ptrn.ResultPattern();

            Console.WriteLine("result = {0}", ds.GetMultiplySeries(value,startValue,stopValue));

            Console.ReadKey();
        }
    }
}
