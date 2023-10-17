using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PomazDS.Sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double mult = 1.0;
            int k = startValue;
            while (k <= stopValue)
            {
                mult *= Math.Pow(3.0 / k, -2);
                k++;
            }
            return Math.Round(mult, 3);
        }
    }
}
