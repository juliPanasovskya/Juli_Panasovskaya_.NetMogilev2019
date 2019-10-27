using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            string stringNumbers = Console.ReadLine();

            char[] array = stringNumbers.ToCharArray();

            int number = Convert(OverNumbers(array));

            Console.WriteLine($"{number}");

            Console.ReadKey();
        }
        /// <summary>
        /// Exchange the position of numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns> array of char </returns>
        static char[] OverNumbers(char[] array)
        {
            char temp;
            int j = array.Length - 1;

            for (int i = 0; i < j; i++)
            {

                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                j--;
            }


            return array;
        }
        /// <summary>
        /// Convert array of char to a numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns>number</returns>
        static int Convert(char[] array)
        {
            string str1 = null;
            string str = null;
            foreach (char item in array)
            {
                str1 = item.ToString();
                str = string.Concat(str, str1);
            }


            int number = int.Parse(str);
            return number;
        }



    }
}
