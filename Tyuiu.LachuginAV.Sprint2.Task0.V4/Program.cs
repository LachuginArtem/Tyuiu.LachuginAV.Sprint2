using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LachuginAV.Sprint2.Task0.V4.Lib;


namespace Tyuiu.LachuginAV.Sprint2.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 333; int y = 324;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Лачугин Артем | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2 *");
            Console.WriteLine("* Тема: Операции сравнения *");
            Console.WriteLine("* Задание #0 *");
            Console.WriteLine("* Вариант #4 *");
            Console.WriteLine("* Выполнил: | АСОиУб-23-3 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу из операций сравнений *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую *");
            Console.WriteLine("* последовательность(массив): (False, True, False, True, False, True) *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 333, y = 324 *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
    
}
