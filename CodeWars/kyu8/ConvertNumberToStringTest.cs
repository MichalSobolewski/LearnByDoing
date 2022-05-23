using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/5265326f5fda8eb1160004c8[TestFixture]
    public class ConvertNumberToStringTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(67).Returns("67");
                yield return new TestCaseData(79585).Returns("79585");
                yield return new TestCaseData(1 + 2).Returns("3");
                yield return new TestCaseData(1 - 2).Returns("-1");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(int num) => ConvertNumberToString.NumberToString(num);
    }

    public class ConvertNumberToString
    {
        public static string NumberToString(int num) => $"{num}";
    }
}
