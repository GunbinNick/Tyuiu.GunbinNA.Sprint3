using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task3.V30.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Оператор цикла foreach                                             *");
            Console.WriteLine("*Задание #3.3                                                             *");
            Console.WriteLine("*Вариант #30                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу используя цикл foreach, которая вычисляет кол-во      *");
            Console.WriteLine("*символов y в строке fyyklbtyn ygrc vfyyyyh                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            string x;
            char y;

            Console.WriteLine("Введите исходную строку: ");
            x = Console.ReadLine();
            Console.WriteLine("Введите искомый символ: ");
            y = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.GetMaxCharCount(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
