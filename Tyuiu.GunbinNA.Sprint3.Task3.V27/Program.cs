using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task2.V27.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Оператор цикла do-while                                            *");
            Console.WriteLine("*Задание #3.2                                                             *");
            Console.WriteLine("*Вариант #27                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет сумму    *");
            Console.WriteLine("*ряда по формуле, при x = 5                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int x, y, z = 5;

            Console.WriteLine("Введите начальное значение: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.GetSumSeries(z, x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
