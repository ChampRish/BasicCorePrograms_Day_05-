using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram_Day_5
{
    public class Q_6_QuotientAndRemainder
    {
        public static void quotRem()
        {
            int dividend;
            int divisor;
            Console.WriteLine("Enter the Dividend : ");
            dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Divisor : ");
            divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);     //placeholder decliration
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
