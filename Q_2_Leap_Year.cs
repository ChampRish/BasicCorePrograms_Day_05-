using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram_Day_5
{
    public class Q_2_Leap_Year
    {
        public static void LeapYear()        
        {
            Console.Write("Enter your Year: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine("This year is leap year");
            else
                Console.WriteLine("This year is not leap year");
        }
    }
}
