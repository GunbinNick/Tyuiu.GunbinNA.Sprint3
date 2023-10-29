using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task6.V25.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task6.V25
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
            Console.WriteLine("*Задание #3.6                                                             *");
            Console.WriteLine("*Вариант #25                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих        *");
            Console.WriteLine("*числовому отрезку [16, 24] сумму всех делителей меньше 10                *");
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

            var res = ds.GetSumTheDivisors(start, end);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

