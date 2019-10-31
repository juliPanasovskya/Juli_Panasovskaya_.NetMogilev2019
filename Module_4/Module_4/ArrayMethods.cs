using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public static class ArrayMethods
    {

        public static void EnterArraySize(out int n)
        {
            Console.Write("Enter the size of array: ");
            bool parsing = int.TryParse(Console.ReadLine(), out n);
            if (!parsing)
            {
                Console.WriteLine("The wrong type of number!");
            }
        }

        public static void CreateArrayInt(int n, out int[] array)
        {
            array = new int[n];

            Console.WriteLine("Enter elements: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                bool parsing = int.TryParse(Console.ReadLine(), out array[i]);
                if (!parsing)
                {
                    Console.WriteLine("The wrong type of number!");
                }
            }
        }

        public static void DisplayArrayInt(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write("{0} \t ", item);
            }
        }

        /// <summary>
        /// Find Max element in the array
        /// </summary>
        /// <param name="max"> Out Max element </param>
        /// <param name="args">array of int </param>
        public static void GetMaxArrayEl(out int max, params int[] args)
        {
            int i = 0;
            max = args[i];

            for (i = 0; i < args.Length; i++)
            {
                if (args[i] > max)
                {
                    max = args[i];
                }
            }
        }

        /// <summary>
        /// Find Min element in the array
        /// </summary>
        /// <param name="min"> Out Min element </param>
        /// <param name="args">array of int </param>
        public static void GetMinArrayEl(out int min, params int[] array)
        {
            int i = 0;
            min = array[i];
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
        }
        public static void GetSumArrayEl( out int sum,params int[] array )
        {
            sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
        }
        public static int GetDiffernceMaxMinArrayEl(int max, int min)
        {
            int dif = 0;
            dif = max - min;
            return dif;
        }
        public static int[] ChangeArrayEl(int[] array, int max, int min)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = array[i] + max;
                }
                else
                {
                    array[i] = array[i] - min;
                }
            }
            return array;
        }
        public static void GetSumOfTwoArrays(out int[] sum, int[] array, int[] array2)
        {
            if (array.Length >= array2.Length)
            {
                sum = new int[array.Length];
                for (int i = 0; i < sum.Length; i++)
                {
                    if (array2.Length - 1 <= i)
                    {
                        sum[i] = array[i];
                    }
                    else
                    {
                        sum[i] = array[i] + array2[i];
                    }
                }
            }
            else
            {
                sum = new int[array2.Length];
                for (int i = 0; i < sum.Length; i++)
                {
                    if (array.Length - 1 <= i)
                    {
                        sum[i] = array2[i];
                    }
                    else
                    {
                        sum[i] = array[i] + array2[i];
                    }
                }
            }


        }
        public static void GetArrayParams(out int max, out int min, out int sum, params int[] array)
        {
            GetMaxArrayEl(out  max, array);
            GetMinArrayEl(out min, array);
            GetSumArrayEl(out sum, array);
        }
        public static void GetArrayElAddFive(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + 5;
            }
        }
        static public void SortArray(bool sortWayMinMax, params int[] array)
        {
            int temp;
            if (sortWayMinMax)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                        }

                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                        }
                    }
                }
            }

        }
    }
}
