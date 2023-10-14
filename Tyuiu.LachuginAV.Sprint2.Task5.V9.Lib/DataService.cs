using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LachuginAV.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)

        {
            {
                int nextDay, nextMonth;

                switch (m)
                {
                    case 1:
                        if (n == 31)
                        {
                            nextDay = 1;
                            nextMonth = 2;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 2:
                        if (n == 28)
                        {
                            nextDay = 1;
                            nextMonth = 3;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 3:
                        if (n == 31)
                        {
                            nextDay = 1;
                            nextMonth = 4;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 4:
                        if (n == 30)
                        {
                            nextDay = 1;
                            nextMonth = 5;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 5:
                        if (n == 31)
                        {
                            nextDay = 1;
                            nextMonth = 6;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 6:
                        if (n == 30)
                        {
                            nextDay = 1;
                            nextMonth = 7;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 7:
                        if (n == 31)
                        {
                            nextDay = 1;
                            nextMonth = 8;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 8:
                        if (n == 31)
                        {
                            nextDay = 1;
                            nextMonth = 9;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 9:
                        if (n == 30)
                        {
                            nextDay = 1;
                            nextMonth = 10;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 10:
                        if (n == 31)
                        {
                            nextDay = 1;
                            nextMonth = 11;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 11:
                        if (n == 30)
                        {
                            nextDay = 1;
                            nextMonth = 12;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    case 12:
                        if (n == 31)
                        {
                            // Не учитываем 31 декабря
                            nextDay = 1;
                            nextMonth = 1;
                        }
                        else
                        {
                            nextDay = n + 1;
                            nextMonth = m;
                        }
                        break;
                    default:
                        nextDay = n;
                        nextMonth = m;
                        break;
                }

                return $"Дата следующего дня: {nextDay}.{nextMonth}";
            }
        }
    }
}
