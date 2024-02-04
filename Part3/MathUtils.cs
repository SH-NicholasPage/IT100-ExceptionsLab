using System;

namespace Part3
{
    public class MathUtils
    {
        public static long Factorial(int n)
        {
            long fact = 1;
            for (int i = n; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
