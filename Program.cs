using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число більше 1: ");
            int x = int.Parse(Console.ReadLine());

            if (x <= 1)
            {
                Console.WriteLine("Введене число менше 1");
                Console.ReadLine();
                return;
            }

            int count = 0;
            for (int i = x + 1; i < 2 * x; i++)
            {
                if (numTrue(i))
                {
                    Console.WriteLine(i);
                    count++;
                }
            }

            Console.WriteLine($"Кількість простих чисел: {count}");
            Console.ReadLine();
        }

        static bool numTrue(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
