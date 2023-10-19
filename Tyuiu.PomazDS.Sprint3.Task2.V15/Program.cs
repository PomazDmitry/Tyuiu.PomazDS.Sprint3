using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task2.V15.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint3.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3, "Оператор цикла do-while", 2, 15, "Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле, при a=0,5", "a=0,5. k=1 to 20");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            ptrn.ResultPattern();

            Console.WriteLine(ds.GetSumSeries(value,startValue,stopValue));

            Console.ReadKey();
        }
    }
}
