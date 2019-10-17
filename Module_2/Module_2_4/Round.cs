using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_4
{
  public  class Round
    {
        public double CalculatePerimetrRound(double radius)
        {
            double perimetrRound = Math.Round(2 * Math.PI * radius, 2);
            Console.WriteLine("Perimetr of the round = {0}\n ", perimetrRound);
            return perimetrRound;
        }
        public void CalculateRadiusRoundByPerimetr(double perimetr)
        {
            double radius = Math.Round(perimetr / (Math.PI * 2), 2);
            Console.WriteLine("Radius of the round, R:{0}\n", radius);
        }
        public double CalculateSquareRound(double radius)
        {
            double squareRound = Math.Round(Math.PI * radius * radius, 2);
            Console.WriteLine("Square of the round = {0}\n", squareRound);
            return squareRound;
        }
        public void CalculateRadiusRoundBySquare(double square)
        {
            double radius = Math.Round(Math.Sqrt(square / (Math.PI)), 2);
            Console.WriteLine("Radius of the round, R:{0}\n", radius);
        }

    }
}
