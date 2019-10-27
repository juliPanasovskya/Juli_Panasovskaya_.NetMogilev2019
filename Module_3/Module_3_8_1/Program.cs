using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_8_1
{
    
        class Program
        {

            static void Main(string[] args)
            {
            Console.Write("Enter array n*n size, n: ");

                int n = int.Parse(Console.ReadLine());

                int[,] array = SpiraleArray(new int[n, n], n);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0} \t", array[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

        /// <summary>
        /// Place the elements of the spirale at the array
        /// </summary>
        /// <param name="array">array n*n</param>
        /// <param name="n">size of n*n array</param>
        /// <returns></returns>
            private static int[,] SpiraleArray(int[,] array, int n)
            {
                int x = 0; // row
                int y = 0;// columns
                int sx = 1; // change by row
                int sy = 0; // change by column

                int filling = n; // amount of filling elements before turing
                int turning = 0; // the number of turning in array 
                for (int i = 0; i < array.Length; i++)
                {
                    array[y, x] = i + 1;

                    --filling;
                    if (filling == 0)
                    {
                        int temp = sx;
                        sx = -sy; 
                        sy = temp;
                        if (turning % 2 == 0)
                        {
                            filling = n - 1;
                            n--;
                        }
                        else
                        {
                            filling = n;

                        }

                        turning++;
                    }
                    x = x + sx; 
                    y = y + sy;
                }

                return array;
            }
        }
    }

