using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_5
{
    public class DayOfWeek
    {
       public enum DayWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thurthday,
            Friday,
            Saturday,
            Sunday
        }
       public   static void WorkDays(DayWeek day)
        {
            if (day >= DayWeek.Monday && day< DayWeek.Saturday)
            {
                Console.WriteLine("{0} is a work day",day);
            }
            else
            {
                Console.WriteLine("{0} is the Day-off",day);
            }
        }
    }
}
