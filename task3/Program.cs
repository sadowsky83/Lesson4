using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        // Количество квадратов в прямоугольнике
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну стороны A (целое число больше нуля)");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длинну стороны B (целое число больше нуля)");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длинну стороны квадрата (целое число больше нуля)");
            int c = Convert.ToInt32(Console.ReadLine());

            int aQuantity = 0;
            int bQuantity = 0;
            int quantity = 0;

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Ошибка! Введены не корректные данные.");
                Console.ReadKey();
            }
            else
            {
                while (a >= c)
                {
                    a -= c;
                    aQuantity++;
                }

                while (b >= c)
                {
                    b -= c;
                    bQuantity++;
                }

                for(int i = 0; i < aQuantity; i++)
                {
                    quantity += bQuantity;
                }

                Console.WriteLine("Количество квадратов в прямоугольнике " + quantity);
                Console.ReadKey();
            }
        }
    }
}
