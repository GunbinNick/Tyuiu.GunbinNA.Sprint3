using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task5.V13.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Вложенные циклы                                                    *");
            Console.WriteLine("*Задание #3.5                                                             *");
            Console.WriteLine("*Вариант #13                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*y = sum(1:3, sum(1:12, cos(x) + k/2, при x = 5                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int x, start1, end1, start2, end2;

            Console.WriteLine("Введите значение переменной: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальное значение первого цикла: ");
            start1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение первого цикла: ");
            end1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальное значение второго цикла: ");
            start2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение второго цикла: ");
            end2 = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.GetSumSumSeries(x,start1, end1, start2, end2);
            Console.WriteLine(res);
            Console.ReadKey();
            
        }
    }
}
