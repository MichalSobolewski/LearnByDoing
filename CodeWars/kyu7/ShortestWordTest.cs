using NUnit.Framework;

namespace CodeWars.kyu7
{
    //https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
    [TestFixture]
    public class ShortestWordTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"));
            Assert.AreEqual(2, ShortestWord.FindShort("Let's travel abroad shall we"));
        }
    }

    public class ShortestWord
    {
        public static int FindShort(string s) => s.Split(" ").Select(x => x.Length).Min();
    }
}
