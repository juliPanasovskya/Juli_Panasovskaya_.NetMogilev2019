using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_5
{
   public static class DaysPerMonthMethod
    {
     public   enum DaysPerMonth: int
        {
            January=31,
            February=28,
            March=31,
            April=30,
            May=31,
            June=30,
            July=31,
            August=31,
            September=30,
            October=31,
            November=30,
            December=31

        }
        public static void FindDaysPerMonth(DaysPerMonth month)
        {
            Console.WriteLine("There are {0} days in {1}",(int)month,month);
        }
    }
}
