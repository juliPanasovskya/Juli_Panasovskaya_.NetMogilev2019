using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_4
{
    class Triangle
    {
        public double CalculatePerimetrTriangle(double a, double b, double c)
        {
            double perimetrTriangle = a + b + c;
            Console.WriteLine("Perimetr of the triangle = {0}\n ", perimetrTriangle);
            return perimetrTriangle;
        }
        public void CalculateSidesTriangleByPerimetr(double perimetr)
        {
            double sideTriangle = Math.Round(perimetr / 3, 2);
            Console.WriteLine("Side of the triangle A,B,C: {0}\n", sideTriangle);
        }
        public double CalculateSquareTriangle(double a, double b, double c)
        {
            double semiPerimetrTriangle = (a + b + c) / 2;
            double squareTriangle = Math.Round(Math.Sqrt(semiPerimetrTriangle * (semiPerimetrTriangle - a) * (semiPerimetrTriangle - b) * (semiPerimetrTriangle - c)), 2);
            Console.WriteLine("Square of the triangle = {0}\n ", squareTriangle);
            return squareTriangle;
        }
        public void CalculateSidesTriangleBySquare(double square)
        {
            double sideTriangle = Math.Round(Math.Sqrt(square * (4 / Math.Sqrt(3))), 2);
            Console.WriteLine("Side of the triangle A,B,C: {0}\n", sideTriangle);
        }

    }
}
