using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Choose the shape.\n1 - Round \n2 - Rectangle \n3 - Triangle\n");
            string selectionShape = Console.ReadLine();
            Console.Write("Choose the calculation.\n1 - Perimetr\n2 - Square\n");
            string selectionCalculation = Console.ReadLine();
            Round round = new Round();
            Triangle triangle = new Triangle();
          
            Rectangle rectangle = new Rectangle();
            switch (selectionShape)
            {
                case "1":
                    Console.Write("Enter the radius.R: \n");
                    switch (selectionCalculation)
                    {
                        case "1":
                            double perimetr = round.CalculatePerimetrRound((double.Parse(Console.ReadLine())));
                            triangle.CalculateSidesTriangleByPerimetr(perimetr);
                            rectangle.CalculateSidesRectangleByPerimetr(perimetr);

                            break;
                        case "2":
                            double square = round.CalculateSquareRound(double.Parse(Console.ReadLine()));
                            triangle.CalculateSidesTriangleBySquare(square);
                            rectangle.CalculateSidesRectangleBySquare(square);
                            break;
                        default:
                            Console.WriteLine("You entered incorrect value. Try again!");
                            break;
                    }
                    break;
                case "2":
                    Console.Write("Enter the side of the rectangle.\nA,B \n");
                    switch (selectionCalculation)
                    {
                        case "1":
                            double perimetr = rectangle.CalculatePerimetrRectangle((double.Parse(Console.ReadLine())), double.Parse(Console.ReadLine()));
                            triangle.CalculateSidesTriangleByPerimetr(perimetr);
                            round.CalculateRadiusRoundByPerimetr(perimetr);
                            break;
                        case "2":
                            double square = rectangle.CalculateSquareRectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            triangle.CalculateSidesTriangleBySquare(square);
                            round.CalculateRadiusRoundBySquare(square);
                            break;
                        default:
                            Console.WriteLine("You entered incorrect value. Try again!");
                            break;
                    }

                    break;
                case "3":
                    Console.Write("Enter the side of the triangle.\nA,B,C\n");
                    switch (selectionCalculation)
                    {
                        case "1":
                            double perimetr = triangle.CalculatePerimetrTriangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            round.CalculateRadiusRoundByPerimetr(perimetr);
                            rectangle.CalculateSidesRectangleByPerimetr(perimetr);
                            break;
                        case "2":
                            double square = triangle.CalculateSquareTriangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())); triangle.CalculateSidesTriangleBySquare(square);
                            round.CalculateRadiusRoundBySquare(square);
                            rectangle.CalculateSidesRectangleBySquare(square);
                            break;
                        default:
                            Console.WriteLine("You entered incorrect value. Try again!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("You entered incorrect value. Try again!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
