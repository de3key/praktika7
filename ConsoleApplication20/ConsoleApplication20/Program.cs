using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            Console.WriteLine("Введите число");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 10);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (k > s)
                {
                    Console.WriteLine("k-й элемент больше");
                }
                else if (s > k)
                {
                    Console.WriteLine("s-й элемент больше");
                }
                else
                {
                    Console.WriteLine("k-й и s-й элементы равны");
                }
                Console.ReadKey();
            }
        }
    }
}
