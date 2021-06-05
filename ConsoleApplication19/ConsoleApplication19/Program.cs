using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] mas = new int[n];
            Console.WriteLine("Введите число");
            Random r = new Random();
            int C = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-44, 35);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {

                if (mas[i] > C)
                {
                    k = k + 1;
                    s = s + mas[i];
                    Console.WriteLine();
                }
                if (k == 0)
                {
                    Console.WriteLine("Среднее арифметическое:");
                }
                else
                {
                    Console.WriteLine("Нету таких чисел", s / k);
                }
                Console.ReadKey();
            }
        }
    }
}

