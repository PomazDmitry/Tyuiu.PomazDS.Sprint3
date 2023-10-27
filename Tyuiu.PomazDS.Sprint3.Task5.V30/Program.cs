using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task5.V30.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint3.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3, "Вложенные циклы", 5, 30, "Вычислить формулу", "1 ряд i = 1 to 3. 2 ряд k= 1 to 11. При x = 2");

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;

            ptrn.ResultPattern();

            Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}
