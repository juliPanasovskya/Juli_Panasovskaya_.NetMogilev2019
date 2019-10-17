using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
        Repeat:
            Console.Clear();
            Console.Write("Enter number A: ");
            string numberA = Console.ReadLine().Replace('.', separator);
            Console.Write("Enter number B: ");
            string numberB = Console.ReadLine().Replace('.', separator);
            double A;
            double B;
            double temp;
            if (double.TryParse(numberA, out A))
            {
               

                if (double.TryParse(numberB, out B))
                {
                    temp = A;
                    A = B;
                    B = temp;

                    Console.WriteLine("A = {0} \nB = {1} ", A, B);

                }
                else
                {
                    Console.WriteLine("The value of number B isn't accepted. You have entered the letters.Try again!");
                    Console.ReadKey();
                    goto Repeat;
                }
            }
            else
            {
                Console.WriteLine("The value of number A isn't accepted. You have entered the letters.Try again!");
                Console.ReadKey();
                goto Repeat;
            }

            Console.ReadKey();

        }
    }
    }

