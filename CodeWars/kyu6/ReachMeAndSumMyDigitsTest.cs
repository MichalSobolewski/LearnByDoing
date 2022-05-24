using NUnit.Framework;

namespace CodeWars.kyu6
{
    //https://www.codewars.com/kata/55ffb44050558fdb200000a4
    public class ReachMeAndSumMyDigitsTest
    {
        [TestFixture]
        public static class SumDigNthTests
        {
            private static void testing(long actual, long expected)
            {
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public static void test1()
            {
                Console.WriteLine("Basic Tests SumDigNthTerm");
                testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 6), 10);
                testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 15), 10);
                testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 50), 9);
                testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 78), 10);
                testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 157), 7);
            }
        }
    }

    public class ReachMeAndSumMyDigits
    {
        public static long SumDigNthTerm(long initval, long[] patternl, int nthterm)
        {
            long tmp = initval;
            long result = 0;

            for (var i = 0; i < nthterm - 1; i++)
            {
                tmp += patternl[i % patternl.Length];
            }

            while (tmp != 0)
            {
                result += tmp % 10;
                tmp /= 10;
            }

            return result;
        }
    }
}
