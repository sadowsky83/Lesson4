using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        // Сравнение количества положительных и отрицательных чисел
        static void Main(string[] args)
        {
            int num; // Число
            int quantityPos = 0; // Количество положительных чисел
            int quantityNeg = 0; // Количество отрицательных чисел

            do
            {
                Console.WriteLine("Введите число (целое число)");
                num = Convert.ToInt32(Console.ReadLine()); // Число

                if (num > 0)
                {
                    quantityPos += 1;
                }

                if (num < 0)
                {
                    quantityNeg += 1;
                }

            } while (num != 0);

            if (quantityPos > quantityNeg)
            {
                Console.WriteLine("Подсчет остановлен. Положительных чисел больше. Количество положительных " + quantityPos + ", количество отрицательных " + quantityNeg + ".");
                Console.ReadKey();
            }

            if (quantityPos < quantityNeg)
            {
                Console.WriteLine("Подсчет остановлен. Отрицательных чисел больше. Количество положительных " + quantityPos + ", количество отрицательных " + quantityNeg + ".");
                Console.ReadKey();
            }

            if (quantityPos == quantityNeg)
            {
                Console.WriteLine("Подсчет остановлен. Количестсо положительных и количество отрицательных равны. Количество положительных " + quantityPos + ", количество отрицательных " + quantityNeg + ".");
                Console.ReadKey();
            }
        }
    }
}
