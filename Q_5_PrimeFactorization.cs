using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram_Day_5
{
    public class Q_5_PrimeFactorization
    {
        public static void Prime()
        {
            int a, b;
            Console.WriteLine("Enter the Number : ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is factor of " + a);
                }
            }
        }
    }
    }
