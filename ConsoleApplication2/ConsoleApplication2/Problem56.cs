using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Problem56
    {
        public static void Execute()
        {
            int maxSum = 0;
            int aSoln = 0;
            int bSoln = 0;
            BigInteger power;
            for(int a = 1; a < 100; a++)
            {
                for(int b = 1; b < 100; b++)
                {
                    power = BigInteger.Pow(a, b);
                    int sum = ComputeDigitalSum(power);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        aSoln = a;
                        bSoln = b;
                    }
                }
            }
            Console.WriteLine(string.Format("The max digital sum is: {0} with a = {1} and b = {2}", maxSum, aSoln, bSoln));
            Console.Read();
        }

        private static int ComputeDigitalSum(BigInteger power)
        {
            int sum = 0;
            var charArr = power.ToString().ToCharArray();
            foreach(char c in charArr)
            {
                int i = (int)char.GetNumericValue(c);
                sum += i;
            }
            return sum;
        }
    }
}
