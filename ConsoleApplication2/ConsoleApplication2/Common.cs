using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Common
    {
        public static BigInteger Factorial(long n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// Credit to mathblog.dk for this function
        /// </summary>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        public static int[] ESieve(int upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }


        /// <summary>
        /// Determines whether the string is a palindrome.
        /// </summary>
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        private static bool IsPrime(int numm)
        {
            if (numm <= 1)
            {
                return false;
            }

            if (numm == 2)
            {
                return true;
            }

            if (numm % 2 == 0)
            {
                return false;
            }

            int counter = 3;

            while ((counter * counter) <= numm)
            {
                if (numm % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter += 2;
                }
            }

            return true;
        }

        public static BigInteger ReverseBigInt(BigInteger i)
        {
            string s = i.ToString();
            char[] charArr = s.ToCharArray();
            Array.Reverse(charArr);
            string sReversed = new string(charArr);

            BigInteger bi;
            if (BigInteger.TryParse(sReversed, out bi))
                return bi;
            else
            {
                Console.WriteLine("Could not reverse: " + i);
                return new BigInteger(-1);
            }
        }
    }
}
