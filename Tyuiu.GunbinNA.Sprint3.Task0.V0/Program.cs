using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task0.V0.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Оператор цикла for                                                 *");
            Console.WriteLine("*Задание #3                                                               *");
            Console.WriteLine("*Вариант #5                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу используя цикл for, которая вычисляет сумму ряда      *");
            Console.WriteLine("*по формуле                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            Console.WriteLine("Введите начальное значение: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.GetSumSeries(x, y);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
