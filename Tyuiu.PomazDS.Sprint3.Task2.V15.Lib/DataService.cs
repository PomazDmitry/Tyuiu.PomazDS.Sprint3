using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PomazDS.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            int k = startValue;
            double sum = 0;

            do
            {
                sum += (Math.Pow(value, k) + 1.0 / 2) * Math.Cos(k);
                k++;
            } while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
