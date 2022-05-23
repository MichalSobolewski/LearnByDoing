using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/55d24f55d7dd296eb9000030
    [TestFixture]
    public static class GrasshopperSummationTest
    {
        [Test]
        public static void BasicTests()
        {
            Assert.AreEqual(1, GrasshopperSummation.summation(1));
            Assert.AreEqual(36, GrasshopperSummation.summation(8));
            Assert.AreEqual(253, GrasshopperSummation.summation(22));
            Assert.AreEqual(5050, GrasshopperSummation.summation(100));
            Assert.AreEqual(22791, GrasshopperSummation.summation(213));
        }
    }

    public class GrasshopperSummation
    {
        public static int summation(int num)
        {
            var result = 0;
            for (var i = 0; i <= num; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
