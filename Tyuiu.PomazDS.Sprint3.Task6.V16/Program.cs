using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task6.V16.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint3.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3, "Обработка целочисленной информации", 6, 16, "Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [5, 16] количество всех делителей");

            int startValue = 5;
            int stopValue = 16;

            ptrn.ResultPattern();

            Console.WriteLine(ds.GetSumTheDivisors(startValue,stopValue));

            Console.ReadKey();
        }
    }
}
