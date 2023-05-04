using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "(sdfsdf(erwte)(dwer)sdc))esdfdw(sdgdsg)gh";
            Console.WriteLine(text + " - текст");

            int count = 0; // к-сть дужок

            foreach (char c in text)
            {
                if (c == '(')
                {
                    count++;
                }
                else if (c == ')')
                {
                    count--;

                    if (count < 0)
                    {
                        break;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Дужки розставлені правильно");
            }
            else
            {
                Console.WriteLine("Дужки розставлені неправильно");
            }

            Console.ReadLine();
        }
    }
}
