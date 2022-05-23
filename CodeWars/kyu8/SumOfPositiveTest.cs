using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/5715eaedb436cf5606000381
    [TestFixture]
    public class SumOfPositiveTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int ExampleTest(int[] arr)
        {
            return SumOfPositive.PositiveSum(arr);
        }
    }

    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr) => arr.Where(x => x > 0).Sum();
    }
}
