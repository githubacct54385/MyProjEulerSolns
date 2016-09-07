using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Problem55
    {
        public static void Execute()
        {
            int count = 0;
            for (int i = 10; i < 10000; i++)
            {
                int iteration = 0;
                bool lychrelNumber = true;
                BigInteger num = i;
                Console.WriteLine("Checking" + i);
                while (lychrelNumber && iteration < 50)
                {
                    BigInteger reverse = Common.ReverseBigInt(num);
                    BigInteger sum = num + reverse;
                    if (Common.IsPalindrome(sum.ToString()))
                    {
                        lychrelNumber = false;
                    }
                    else
                    {
                        iteration++;
                        num = sum;
                    }
                }
                if (lychrelNumber)
                {
                    count++;
                    Console.WriteLine(string.Format("Found Lychrel Number: {0}, Count: {1} ", i, count));
                }
            }
            Console.Read();
        }


    }
}
