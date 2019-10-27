using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_5
{
    class Program
    {
        
            static void Main(string[] args)
            {
            Console.Write("Enter numbers: ");

                string stringNumbers = Console.ReadLine();

            Console.Write("Enter number for deleting: ");

                char charNumber = char.Parse(Console.ReadLine());

                char[] array = stringNumbers.ToCharArray();

                int number = Convert(DeleteNumber(array, charNumber));

                Console.WriteLine($"{number}");

                Console.ReadKey();
            }
        /// <summary>
        /// Deleting selected digit from the number
        /// </summary>
        /// <param name="array">Array of char</param>
        /// <param name="charNumber">Array of char </param>
        /// <returns></returns>
            static char[] DeleteNumber(char[] array, char charNumber)
            {
                char[] array2 = new char[array.Length - 1];
                int k = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == charNumber)
                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            array2[k] = array[j];
                            k++;
                        }
                        break;
                    }
                    else
                    {
                        array2[k] = array[i];
                        k++;
                    }

                }


                return array2;
            }
        /// <summary>
        /// Converting array of char to the number
        /// </summary>
        /// <param name="array">Array of char</param>
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
