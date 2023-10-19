using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task3.V9.Lib;
using autofill_pattern_lib;

namespace Tyuiu.PomazDS.Sprint3.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3, "Оператор цикла foreach", 3, 9, "Используя цикл foreach заменить цифры на букву w в строке: 56hy vfe4r4 vf45b");

            string value = "56hy vfe4r4 vf45b";
            char item = 'w';

            ptrn.ResultPattern();

            Console.WriteLine(ds.ReplaceNumOnChar(value, item));

            Console.ReadKey();
        }
    }
}
