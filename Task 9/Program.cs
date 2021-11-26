using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int operation;

            Console.WriteLine("Давайте посчитаем");
            try
            {
                Console.Write("Введите первое число: ");
                first = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                second = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите математическую операцию: ");
                Console.WriteLine(" 1 : сложение чисел");
                Console.WriteLine(" 2 : вычетание чисел");
                Console.WriteLine(" 3 : умножение чисел");
                Console.WriteLine(" 4 : деление чисел");
                operation = int.Parse(Console.ReadLine());

                if (operation == 1)
                { Console.WriteLine("+=" + (first + second)); }
                if (operation == 2)
                { Console.WriteLine("-=" + (first - second)); }
                if (operation == 3)
                { Console.WriteLine("*=" + (first * second)); }
                if (operation == 4)
                { Console.WriteLine("/=" + (first / second)); }
                
                if (operation != 1 && operation != 2 && operation != 3 && operation != 4)
                { Console.WriteLine("Выш выбор вне допустимых значений"); }
              
            }
            catch (DivideByZeroException ex)
          { Console.WriteLine(ex.Message); }
           
            catch (ArgumentOutOfRangeException ex)
            { Console.WriteLine("ex.Message"); }

            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            Console.ReadKey();
                    }
    }
    }




