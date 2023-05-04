using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                bool isPrime = true; 

                for (int f = 2; f <= Math.Sqrt(i); f++)
                {
                    if (i % f == 0)
                    {
                        isPrime = false; 
                        break; 
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}   


