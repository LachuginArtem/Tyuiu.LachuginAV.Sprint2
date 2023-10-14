using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LachuginAV.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)

        {
            {
                int previousDay, previousMonth;

                switch (m)
                {
                    case 1:
                        if (n == 31)
                        {
                            previousDay = 1;
                            previousMonth = 2;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 2:
                        if (n == 28)
                        {
                            previousDay = 1;
                            previousMonth = 3;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 3:
                        if (n == 31)
                        {
                            previousDay = 1;
                            previousMonth = 4;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 4:
                        if (n == 30)
                        {
                            previousDay = 1;
                            previousMonth = 5;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 5:
                        if (n == 31)
                        {
                            previousDay = 1;
                            previousMonth = 6;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 6:
                        if (n == 30)
                        {
                            previousDay = 1;
                            previousMonth = 7;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 7:
                        if (n == 31)
                        {
                            previousDay = 1;
                            previousMonth = 8;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 8:
                        if (n == 31)
                        {
                            previousDay = 1;
                            previousMonth = 9;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 9:
                        if (n == 30)
                        {
                            previousDay = 1;
                            previousMonth = 10;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 10:
                        if (n == 31)
                        {
                            previousDay = 1;
                            previousMonth = 11;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 11:
                        if (n == 30)
                        {
                            previousDay = 1;
                            previousMonth = 12;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    case 12:
                        if (n == 31)
                        {
                            // Не учитываем 1 января
                            previousDay = 1;
                            previousMonth = 1;
                        }
                        else
                        {
                            previousDay = n - 1;
                            previousMonth = m;
                        }
                        break;
                    default:
                        previousDay = n;
                        previousMonth = m;
                        break;
                }

                return $"Дата предыдущего дня: {previousDay}.{previousMonth}";
            }
        }

    }
}