using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number N: ");
            string numberFromUser = Console.ReadLine();
            int number = int.Parse(numberFromUser);

            if (number % 2 == 0 && number > 18)
            {
                Console.WriteLine("Congratulations! Happy 18th!!!!");
            }
            else
            {
                if (number % 2 == 1 && number > 13 && number < 18)
                {
                    Console.WriteLine("Congratulate on! You are going to hight school!! ");
                }
                else
                {
                    Console.WriteLine("Congratulate on!You are so young!");
                }

            }

            Console.ReadLine();
        }
    }
    }

