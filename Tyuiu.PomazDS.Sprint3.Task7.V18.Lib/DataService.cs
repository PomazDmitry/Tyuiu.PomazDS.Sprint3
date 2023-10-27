using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PomazDS.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array = new double[stopValue - startValue + 1];
            for (int i = startValue, count = 0; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    array[count] = 0;
                    count++;
                    continue;
                }
                array[count] = Math.Round((2 * i - 3) / (Math.Cos(i) + i) + 5, 2);
                count++;
            }
            return array;
        }
    }
}
