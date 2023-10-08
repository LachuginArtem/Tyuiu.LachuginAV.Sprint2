using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LachuginAV.Sprint2.Task1.V28.Lib;


namespace Tyuiu.LachuginAV.Sprint2.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Лачугин Артем | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2 *");
            Console.WriteLine("* Тема: Логические опреации *");
            Console.WriteLine("* Задание #1 *");
            Console.WriteLine("* Вариант #28 *");
            Console.WriteLine("* Выполнил: | АСОиУб-23-3 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу из операций сравнений (==, !=, <, >, <=, >=,*");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать,             *");
            Console.WriteLine("* но использовать один раз в выражении)                                   *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность           *");
            Console.WriteLine("*операций не должна нарушаться), а также арифметических выражений,        *");
            Console.WriteLine("*которая вернет логическую последовательность(массив)                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 247, b = 654, c = 671, d = 671; *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }

}
