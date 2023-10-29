using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task7.V19.Lib;
namespace Tyuiu.GunbinNA.Sprint3.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("*Задание #3.7                                                             *");
            Console.WriteLine("*Вариант #19                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая выводит таблицу значений функции             *");
            Console.WriteLine("*f(x) = (5x + 2.5 / sin(x) - 2) + 2 (произвести табулирование) f(x) на    *");
            Console.WriteLine("*заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль*");
            Console.WriteLine("*При делении на ноль вернуть значение 0. Значения округлить до двух знаков*");
            Console.WriteLine("*после запятой                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int start, end;

            Console.WriteLine("Введите начальное значение: ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            end = int.Parse(Console.ReadLine());

            int len = ds.GetMassFunction(start, end).Length;
            double[] waitarray = new double[len];

            waitarray = ds.GetMassFunction(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     +   f(x)    |");
            Console.WriteLine("+----------+-----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}   |", start, waitarray[i]);
                start++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();

        }
    }
}
