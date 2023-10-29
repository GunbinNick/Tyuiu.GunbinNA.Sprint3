using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task4.V19.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Использование операторов continue и break в циклах                 *");
            Console.WriteLine("*Задание #3.4                                                             *");
            Console.WriteLine("*Вариант #19                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5, вычислить значение      *");
            Console.WriteLine("*функции y=x/(cos(x) + x)+0.5. При х = 0 прервать цикл. Полученные        *");
            Console.WriteLine("*значения перемножать                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int start, end;

            Console.WriteLine("Введите начальное значение: ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(start, end);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
