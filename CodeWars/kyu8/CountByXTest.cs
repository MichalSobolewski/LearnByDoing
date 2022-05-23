using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/5513795bd3fafb56c200049e[TestFixture]
    public static class CountByXTest
    {
        [Test]
        public static void CountBy1()
        {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, CountByX.CountBy(1, 5), "Array does not match");
        }

        [Test]
        public static void CountBy2()
        {
            Assert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, CountByX.CountBy(2, 5), "Array does not match");
        }
    }

    public class CountByX
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            z[0] = x;
            for (var i = 1; i < n; i++)
            {
                z[i] = x + z[i - 1];
            }

            return z;
        }
    }
}
