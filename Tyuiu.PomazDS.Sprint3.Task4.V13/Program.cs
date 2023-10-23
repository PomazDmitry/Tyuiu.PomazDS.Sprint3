using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task4.V13.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint3.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3, "Использование операторов continue и break в циклах", 4, 13, "На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=sin(x)/cos(x). При х = 0 прервать цикл. Полученные значения перемножать.");

            int startValue = -5;
            int stopValue = 5;

            ptrn.ResultPattern();

            Console.WriteLine(ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
