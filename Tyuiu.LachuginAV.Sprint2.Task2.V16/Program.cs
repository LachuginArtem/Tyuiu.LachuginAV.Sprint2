using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LachuginAV.Sprint2.Task2.V16.Lib;


namespace Tyuiu.LachuginAV.Sprint2.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Лачугин Артем | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2 *");
            Console.WriteLine("* Тема: Оператор if *");
            Console.WriteLine("* Задание #2 *");
            Console.WriteLine("* Вариант #16 *");
            Console.WriteLine("* Выполнил: | АСОиУб-23-3 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу на, которая запрашивает целые значения с    *");
            Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y            *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение Х:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка находится в не заштрихованной области");
            }
            Console.ReadKey();

        }
    }

}
