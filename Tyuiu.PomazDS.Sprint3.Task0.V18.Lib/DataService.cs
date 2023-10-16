using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PomazDS.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int x = 1;
            double p = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                p *= Math.Pow(2 / (Math.Cos(x) + 0.5), k);
            }
            return Math.Round(p, 3);
        }
    }
}
