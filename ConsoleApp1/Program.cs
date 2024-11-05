using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11.Вывести такие значения.
            //            Random rng = new Random();
            //            int[] omas = new int[10];
            //            for (int i = 0; i < omas.Length; i++)
            //            {
            //                omas[i] = rng.Next(1, 101);
            //            }
            //            foreach (int num in omas)
            //            {
            //                if (num % 11 == 0)
            //                {
            //                    Console.WriteLine(num);
            //                }
            //                Console.ReadKey();
            //            }
            //        }
            //    }
            //}
            //Задача 2. Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            //            int[] omas = new int[] { 5, -4, 8, 7, -2 };
            //            int value = 0;
            //            int count = 0;
            //            for (int i = 0; i < omas.Length; i++)
            //            {
            //                if (omas[i] > 0)
            //                {
            //                    value += omas[i];
            //                    count++;
            //                }
            //            }
            //            Console.WriteLine($"Сумма: {value}\n кол-во:{count}");
            //            Console.ReadKey();
            //        }
            //    }
            //}

            //Задача 3. Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.
            const int n = 6;
            int[] omas = new int[n];
            Random rng = new Random();

            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rng.Next(0, 99);
                Console.WriteLine($"omas[{i}] = {omas[i]}");
            }
            Array.Reverse(omas);
            Console.WriteLine("\nМассив в обратном порядке:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(omas[i]);
            //for (int i = omas.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(omas[i]);
            //}

            Console.ReadKey();
        }
    }
}