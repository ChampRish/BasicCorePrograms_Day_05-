using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram_Day_5
{
    public class Q_1_FlipCoin
    {
        public static void HeadCount()
        {
            int head = 0;
            int tail = 0;
            int count = 0;
            while (count < 20)
            {
                Random rnd = new Random();
                int result = rnd.Next(0,2);
                if (result == 1)
                {
                    // Console.WriteLine("Tail");
                    tail++;
                    count++;
                }
                else if (result == 0)
                {
                    //Console.WriteLine("Head");
                    head++;
                    count++;
                }
            }
            
            Console.WriteLine("Head:" + head + "%" + "\nTail: " + tails + "%" + "\nCount: " + count);
            Console.WriteLine("Heads = " + (head * 100f / count) + "%" + " Tails = " + tails * 100f / count + "%");
        }
    }
}
