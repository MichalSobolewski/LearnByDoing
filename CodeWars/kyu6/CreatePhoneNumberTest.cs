using NUnit.Framework;

namespace CodeWars.kyu6
{
    //https://www.codewars.com/kata/525f50e3b73515a6db000b83
    [TestFixture]
    public class CreatePhoneNumberTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public static string FixedTest(int[] numbers)
        {
            return CreatePhoneNumberSolution.CreatePhoneNumber(numbers);
        }
    }

    public class CreatePhoneNumberSolution
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            String result = "";

            for (var i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            result = result.Insert(0, "(");
            result = result.Insert(4, ") ");
            result = result.Insert(9, "-");

            return result;
        }
    }
}
