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
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            
            double mult = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                mult *= Math.Pow(2 / (Math.Cos(value) + 0.5), k);
            }
            return Math.Round(mult, 3);
        }
    }
}
