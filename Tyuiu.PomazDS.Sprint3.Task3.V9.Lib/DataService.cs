using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PomazDS.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
     
            foreach (var c in value)
            {
                if (char.IsDigit(c))
                {
                    value = value.Replace(c, 'w');
                }       
            }
            return value;
        }
    }
}
