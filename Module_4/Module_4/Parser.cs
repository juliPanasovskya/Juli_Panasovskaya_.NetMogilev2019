using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public static class Parser
    {
        public static void Parse(out int a)
        {
            bool parcing = int.TryParse(Console.ReadLine(), out a);
            if (!parcing)
            {
                Console.WriteLine("The wrong number! Enter number which type is integer");
            }
        }
        public static void Parse(out double a)
        {
            string str = ReplaceSeparator(Console.ReadLine());
            bool parcing = double.TryParse(str, out a);
            if (!parcing)
            {
                Console.WriteLine("The wrong number! Enter number which type is double");
            }
        }
        public static void Parse(out char a)
        {
            
            bool parcing = char.TryParse(Console.ReadLine(), out a);
            if (!parcing)
            {
                Console.WriteLine("The wrong item! Enter item which type is char");
            }
        }
        
        private static string ReplaceSeparator(string str)
        {
            var c = System.Threading.Thread.CurrentThread.CurrentCulture;
            var s = c.NumberFormat.CurrencyDecimalSeparator;
            str = str.Replace(".", s);
            str = str.Replace(",", s);
            return str;
        }
    }
}
