using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alg_lab5
{
    using System;
    class SubsetsProgram
    {
        // Функция для печати подмножеств
        static void PrintSubsets(int[] subset, int n)
        {
            Console.Write("{ ");
            for (int i = 0; i < n; i++)
            {
                if (subset[i] != 0)
                {
                    Console.Write(subset[i] + " ");
                }
            }
            Console.WriteLine("}");
        }

        // Рекурсивная функция для генерации всех подмножеств
        static void GenerateSubsets(int[] subset, int k, int n)
        {
            if (k == n)
            {
                PrintSubsets(subset, n);
                return;
            }
            subset[k] = 0;
            GenerateSubsets(subset, k + 1, n);
            subset[k] = k + 1;
            GenerateSubsets(subset, k + 1, n);
        }

        // Основная функция
        static void Main()
        {
            int N;
            Console.Write("Введите N: ");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
            {
                Console.WriteLine("Введите корректное положительное целое число N:");
            }

            if (N == 0)
                Console.WriteLine("Все подмножества пустого множества\n{ }");
            else
            {
                int[] subset = new int[N];

                Console.WriteLine("Все подмножества множества {1, 2, ..., N}:");
                GenerateSubsets(subset, 0, N);
            }
            Console.ReadKey();
        }
    }

}
