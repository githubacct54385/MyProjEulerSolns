using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Problem53
    {

        public static void Execute()
        {
            int count = 0;
            for (long n = 1; n <= 100; n++)
            {
                for (long r = 0; r <= n; r++)
                {
                    BigInteger sol = ComputeCombinatorialSolution(n, r);
                    if (sol <= 1000000) continue;
                    count++;
                    Console.WriteLine($"Found solution: {sol}, Count: {count}");
                }
            }
            Console.Read();
        }

        private static BigInteger ComputeCombinatorialSolution(long n, long r)
        {
            if (n - r == 0 || r == 0) return 1;

            BigInteger factorialN = Common.Factorial(n);
            BigInteger factorialR = Common.Factorial(r);
            BigInteger factorialNminusR = Common.Factorial(n - r);
            return factorialN / (factorialR * factorialNminusR);
        }

    }
}
