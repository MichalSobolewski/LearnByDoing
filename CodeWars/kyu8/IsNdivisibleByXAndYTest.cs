using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/5545f109004975ea66000086
    [TestFixture]
    public class IsNdivisibleByXAndYTest
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, IsNdivisibleByXAndY.isDivisible(12, 4, 3));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, IsNdivisibleByXAndY.isDivisible(3, 3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, IsNdivisibleByXAndY.isDivisible(8, 3, 4));
        }

    }

    public class IsNdivisibleByXAndY
    {
        public static bool isDivisible(long n, long x, long y) => n % x == 0 && n % y == 0;

    }
}
