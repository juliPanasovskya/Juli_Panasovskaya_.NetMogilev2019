using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_4
{
   public class Rectangle
    {
        public double CalculatePerimetrRectangle(double a, double b)
        {
            double perimetrRectangle = (a + b) * 2;
            Console.WriteLine("Perimetr of the rectangle = {0} \n", perimetrRectangle);
            return perimetrRectangle;
        }
        public void CalculateSidesRectangleByPerimetr(double perimetr)
        {
            double sideRectangle = Math.Round(perimetr / 4, 2);
            Console.WriteLine("Side of the rectangle A,B: {0} \n", sideRectangle);
            
        }

        public double CalculateSquareRectangle(double a, double b)
        {
            double squareRectangle = a * b;
            Console.WriteLine("Square of the rectangle = {0}\n ", squareRectangle);
            return squareRectangle;
        }
        public void CalculateSidesRectangleBySquare(double square)
        {
            double sideRectangle = Math.Round(Math.Sqrt(square), 2);
            Console.WriteLine("Side of the rectangle A,B: {0}\n", sideRectangle);
            
        }

    }
}
