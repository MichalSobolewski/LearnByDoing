using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/53ee5429ba190077850011d4
    [TestFixture]
    public class YouCantCodeUnderPressure1Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(2).Returns(4);
                yield return new TestCaseData(4).Returns(8);
                yield return new TestCaseData(-10).Returns(-20);
                yield return new TestCaseData(0).Returns(0);
                yield return new TestCaseData(100).Returns(200);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(int n) => YouCantCodeUnderPressure1.DoubleInteger(n);
    }

    public class YouCantCodeUnderPressure1
    {
        public static int DoubleInteger(int n) => n * 2;
    }
}
