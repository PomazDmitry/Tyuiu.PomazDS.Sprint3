using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task1.V1.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint3.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3, "Оператор цикла while", 1, 1, "Написать программу используя цикл while, которая вычисляет произведение ряда по формуле","k = 1 to 7");

            int startValue = 1;
            int endValue = 7;

            ptrn.ResultPattern();

            Console.WriteLine(ds.GetMultiplySeries(startValue, endValue));

            Console.ReadKey();
        }
    }
}
