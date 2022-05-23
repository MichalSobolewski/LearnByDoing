using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/55685cd7ad70877c23000102
    [TestFixture]
    public class ReturnNegativeTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, ReturnNegative.MakeNegative(42));
        }
    }

    public class ReturnNegative
    {
        public static int MakeNegative(int number) => -Math.Abs(number);
    }
}
