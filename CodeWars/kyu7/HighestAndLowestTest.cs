using NUnit.Framework;

namespace CodeWars.kyu7
{
    //https://www.codewars.com/kata/554b4ac871d6813a03000035[TestFixture]
    public class HighestAndLowestTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("3 1", HighestAndLowest.HighAndLow("1 2 3"));
        }
    }

    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            var n = numbers.Split().Select(int.Parse);
            return $"{n.Max()} {n.Min()}";
        }
    }
}
