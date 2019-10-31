using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_5
{
    public static   class MathOperationMethod
    {
        public enum Operation
        {
            Add,
            Substarct,
            Multiply,
            Divide
        }
       public static void Operations(double x, double y, Operation op)
        {
            double result = 0;
            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    Console.WriteLine("{0}+{1} = {2}", x, y, result);
                    break;
                case Operation.Substarct:
                    result = x - y;
                    Console.WriteLine("{0}-{1} = {2}", x, y, result);
                    break;
                case Operation.Multiply:
                    result = Math.Round(x * y,3);
                    Console.WriteLine("{0}*{1} = {2}", x, y, result);
                    break;
                case Operation.Divide:
                    result = Math.Round(x / y,3);
                    Console.WriteLine("{0}/{1} = {2}", x, y, result);
                    break;
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
        }
    }
}
