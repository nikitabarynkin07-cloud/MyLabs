using System;

namespace Lab1
{
    public static class Recursion
    {
        public static int FindMaxDigit(int n)
        {
            if (n < 10)
                return n;

            int lastDigit = n % 10;
            int maxOfRest = FindMaxDigit(n / 10);
            return Math.Max(maxOfRest, lastDigit);
        }
    }
}