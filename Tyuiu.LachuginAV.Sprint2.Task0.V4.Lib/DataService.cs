using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.LachuginAV.Sprint2.Task0.V4.Lib
{
    public class DataService : ISprint2Task0V4
    {
        
            public bool[] GetCompareOperations(int x, int y)
            {
                bool[] array = new bool[6];

                array[0] = x == y;
                array[1] = x != y;
                array[2] = x < y;
                array[3] = x > y;
                array[4] = x <= y;
                array[5] = x >= y;

                return array;
            }
        
    }
}
