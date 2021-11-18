using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Квадрат числа N2=1 + 3 + 5 + ... + (2*N – 1)
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (целое число больше нуля)");
            int num = Convert.ToInt32(Console.ReadLine()); // Число
            int square = 0;

            if (num <= 0)
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("Ошибка! Число равно нулю.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Ошибка! Число меньше нуля.");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    square = square + (2 * i - 1);
                }
                Console.WriteLine("Квадрат числа равен " + square);
                Console.ReadKey();
            }
        }
    }
}
