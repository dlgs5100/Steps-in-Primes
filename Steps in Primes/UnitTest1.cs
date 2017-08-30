using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Steps_in_Primes
{

    [TestFixture]
    public static class StepInPrimesTests
    {
        [Test]
        public static void test()
        {
            Assert.AreEqual(new int[] { 101, 103 }, StepInPrimes.Step(2, 100, 110));
            Assert.AreEqual(new int[] { 103, 107 }, StepInPrimes.Step(4, 100, 110));
            Assert.AreEqual(new int[] { 101, 107 }, StepInPrimes.Step(6, 100, 110));
            Assert.AreEqual(new int[] { 359, 367 }, StepInPrimes.Step(8, 300, 400));
            Assert.AreEqual(new int[] { 307, 317 }, StepInPrimes.Step(10, 300, 400));
        }
    }
    class StepInPrimes
    {
        public static long[] Step(int g, long m, long n)
        {
            for (long i = m; i <= n; i++)
            {
                if (isPrime(i))
                    if (isPrime(i + g) && (i + g) <= n)
                        return new long[] { i, i + g };
            }
            return null;
        }
        public static bool isPrime(long value)
        {
            if (value == 1)
                return false;
            if (value % 2 == 0)
            {
                if (value == 2)
                    return true;
                else
                    return false;
            }

            bool result = true;
            for (long i = 3; (i * i) <= value; i += 2)
            {
                if (value % i == 0)
                    result = false;
            }
            return result;
        }
    }
}
