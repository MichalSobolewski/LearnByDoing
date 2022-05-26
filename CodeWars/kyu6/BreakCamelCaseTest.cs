using NUnit.Framework;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.kyu6
{
    //https://www.codewars.com/kata/5208f99aee097e6552000148
    [TestFixture]
    public class BreakCamelCaseTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string str) => BreakCamelCase_.BreakCamelCase(str);

        [Test, TestCaseSource("testCases")]
        public string Test2(string str) => BreakCamelCase_.BreakCamelCase2(str);

        [Test, TestCaseSource("testCases")]
        public string Test3(string str) => BreakCamelCase_.BreakCamelCase3(str);
    }

    public class BreakCamelCase_
    {
        public static string BreakCamelCase(string str)
        {
            StringBuilder result = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str, i) && i > 0)
                {
                    result.Append(" ");
                    result.Append(str[i]);
                }
                else
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }

        public static string BreakCamelCase2(string str)
        {
            var result = string.Concat(str.Select(c => char.IsUpper(c) ? " " + c : c.ToString()));

            return result;
        }

        // Solution of other user, good to know.
        // Replaces each capital letter with itself preceded by a space!
        public static string BreakCamelCase3(string str) => new Regex("([A-Z])").Replace(str, " $1");
    }

}
