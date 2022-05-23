using NUnit.Framework;

namespace CodeWars.kyu7
{
    //https://www.codewars.com/kata/54ff3102c1bad923760001f3
    [TestFixture]
    public class VowelCountTest
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }

    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            return str.Count(x => vowels.Contains(x));
        }
    }
}
