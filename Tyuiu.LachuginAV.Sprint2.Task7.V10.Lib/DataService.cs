using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LachuginAV.Sprint2.Task7.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.LachuginAV.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y <= x || y <= -x) && y <= x * x - 2)
            {
                return true;
            }
            return false;
        }
    }
}