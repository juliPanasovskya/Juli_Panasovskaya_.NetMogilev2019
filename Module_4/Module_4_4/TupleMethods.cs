using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_4
{
  public static  class TupleMethods
    {
        public static void IncreaseElement(ref (int a, int b, int c) values)
        {
            values.a += 10;
            values.b += 10;
            values.c += 10;
        }

        public static void GetCircleParams(double r, out (double length, double square) parametr)
        {
            parametr.length = Math.Round(2 * r * Math.PI, 3);
            parametr.square = Math.Round(Math.PI * Math.Pow(r, 2), 3);
        }

        public static void GetArrayParams(out (int max, int min, int sum) arrayValues, params int[] array)
        {
            int i = 0;
            arrayValues.max = array[i];
            arrayValues.min = array[i];
            arrayValues.sum = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > arrayValues.max)
                {
                    arrayValues.max = array[i];
                }
                if (array[i] < arrayValues.min)
                {
                    arrayValues.min = array[i];
                }
                arrayValues.sum = arrayValues.sum + array[i];
            }
        }
    }
}
