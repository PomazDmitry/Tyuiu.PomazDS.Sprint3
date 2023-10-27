using autofill_pattern_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint3.Task7.V18.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();

            ptrn.MainPattern(3, "Добавление к решению итоговых проектов по спринту", 7, 18, "Написать программу, которая выводит таблицу значений функции: f(x) = (2x-3)/(cos(x)+x)+5 (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0. Значения округлить до двух знаков после запятой. Значения занести в массив!");

            int startValue = -5;
            int stopValue = 5;
            double[] array = ds.GetMassFunction(startValue,stopValue);

            ptrn.ResultPattern();


            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("|{0,5}     |{1,7}   |", startValue, array[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}
