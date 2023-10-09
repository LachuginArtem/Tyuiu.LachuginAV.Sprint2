using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LachuginAV.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            if (x > 3)
            {
                return Math.Round(x - (12 * x) + Math.Cos(x), 3);
            }
            if (x == 2)
            {
                return Math.Round(x - (1/x), 3);
            }
            if (-6 < x && x < 1 ) 
            {
                return Math.Round(Math.Pow(x, 5) + 10 * x - (1/Math.Sqrt(x+3)) , 3);
            }
            else
            {
                return Math.Round(x + 10 * x - (1 / Math.Pow(x, 4) ), 3);
            }
        }
    }
}
