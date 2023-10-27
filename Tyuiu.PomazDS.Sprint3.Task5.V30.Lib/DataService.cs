using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PomazDS.Sprint3.Task5.V30.Lib
{
    public class DataService : ISprint3Task5V30
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    sum += Math.Pow(x, 3) - k + x;
                }
            }
            return sum;
        }
    }
}
