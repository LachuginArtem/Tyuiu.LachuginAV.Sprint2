using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.LachuginAV.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (x == 3 & y == 3) { return true; }
            if (x == 4 & y == 3) { return true; }
            if (x == 5 & y == 3) { return true; }
            if (x == 13 & y == 3) { return true; }
            if (x == 14 & y == 3) { return true; }
            if (x == 3 & y == 4) { return true; }
            if (x == 4 & y == 4) { return true; }
            if (x == 5 & y == 4) { return true; }
            if (x == 13 & y == 4) { return true; }
            if (x == 14 & y == 4) { return true; }
            if (x == 3 & y == 5) { return true; }
            if (x == 4 & y == 5) { return true; }
            if (x == 5 & y == 5) { return true; }
            if (x == 6 & y == 5) { return true; }
            if (x == 7 & y == 5) { return true; }
            if (x == 13 & y == 5) { return true; }
            if (x == 14 & y == 5) { return true; }
            if (x == 3 & y == 6) { return true; }
            if (x == 4 & y == 6) { return true; }
            if (x == 5 & y == 6) { return true; }
            if (x == 6 & y == 6) { return true; }
            if (x == 7 & y == 6) { return true; }
            if (x == 8 & y == 6) { return true; }
            if (x == 9 & y == 6) { return true; }
            if (x == 13 & y == 6) { return true; }
            if (x == 14 & y == 6) { return true; }
            if (x == 3 & y == 7) { return true; }
            if (x == 4 & y == 7) { return true; }
            if (x == 5 & y == 7) { return true; }
            if (x == 6 & y == 7) { return true; }
            if (x == 7 & y == 7) { return true; }
            if (x == 8 & y == 7) { return true; }
            if (x == 9 & y == 7) { return true; }
            if (x == 10 & y == 7) { return true; }
            if (x == 11 & y == 7) { return true; }
            if (x == 12 & y == 7) { return true; }
            if (x == 13 & y == 7) { return true; }
            if (x == 14 & y == 7) { return true; }
            if (x == 6 & y == 8) { return true; }
            if (x == 7 & y == 8) { return true; }
            if (x == 8 & y == 8) { return true; }
            if (x == 9 & y == 8) { return true; }
            if (x == 13 & y == 8) { return true; }
            if (x == 14 & y == 8) { return true; }
            if (x == 6 & y == 9) { return true; }
            if (x == 7 & y == 9) { return true; }
            if (x == 13 & y == 9) { return true; }
            if (x == 14 & y == 9) { return true; }
            if (x == 6 & y == 10) { return true; }
            if (x == 7 & y == 10) { return true; }
            if (x == 13 & y == 10) { return true; }
            if (x == 14 & y == 10) { return true; }
            if (x == 3 & y == 11) { return true; }
            if (x == 4 & y == 11) { return true; }
            if (x == 5 & y == 11) { return true; }
            if (x == 6 & y == 11) { return true; }
            if (x == 7 & y == 11) { return true; }
            if (x == 3 & y == 12) { return true; }
            if (x == 7 & y == 12) { return true; }
            if (x == 8 & y == 12) { return true; }
            if (x == 9 & y == 12) { return true; }
            if (x == 10 & y == 12) { return true; }
            if (x == 10 & y == 13) { return true; }
            if (x == 11 & y == 13) { return true; }
            if (x == 12 & y == 13) { return true; }
            else { return false; }
        }
    }
}
