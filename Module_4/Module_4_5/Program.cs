using Module_4;
using System;
namespace Module_4_5
{

    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b: ");
            Parser.Parse(out double a);
            Parser.Parse(out double b);
            Console.Write("Choose the operation:\n 1-Add\n 2-Substarct\n 3-Multiply \n 4-Divide\n");
            Parser.Parse(out char item);
            switch (item)
            {
                case '1':
                    MathOperationMethod.Operations(a, b, MathOperationMethod.Operation.Add);
                    break;
                case '2':
                    MathOperationMethod.Operations(a, b, MathOperationMethod.Operation.Substarct);
                    break;
                case '3':
                    MathOperationMethod.Operations(a, b, MathOperationMethod.Operation.Multiply);
                    break;
                case '4':
                    MathOperationMethod.Operations(a, b, MathOperationMethod.Operation.Divide);
                    break;
                default:
                    Console.WriteLine("The wrong operation!");
                    break;
            }
            DaysPerMonthMethod.FindDaysPerMonth(DaysPerMonthMethod.DaysPerMonth.January);
            DayOfWeek.WorkDays(DayOfWeek.DayWeek.Wednesday);
            Console.ReadLine();
        }
    }

}
