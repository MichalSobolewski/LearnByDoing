using NUnit.Framework;

namespace CodeWars.kyu7
{
    //https://www.codewars.com/kata/546e2562b03326a88e000020
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(811181, SquareEveryDigit.SquareDigits(9119));
            Assert.AreEqual(0, SquareEveryDigit.SquareDigits(0));
        }
    }

    public class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            int result = 0;
            int places = 0;

            while (n > 0)
            {
                int tmp = (int)Math.Pow(n % 10, 2);
                result += (int)Math.Pow(10, places) * tmp;
                places += tmp > 10 ? 2 : 1;
                n /= 10;
            }

            return result;
        }
    }
}
