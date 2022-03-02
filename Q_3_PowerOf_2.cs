using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram_Day_5
{
    public class Q_3_PowerOf_2
    {
        public static void powerTwo()
        {
            Console.WriteLine("Enter the value of N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            {
                double pow_t = Math.Pow( 2, n);
                Console.WriteLine(pow_t);
                if ((pow_t % 4 == 0))
                {
                    Console.WriteLine("This Year is a Leap Year");
                }
                else
                {
                    Console.WriteLine("This Year is Not a Leap Year");
                }
            }
        }
    }
}
