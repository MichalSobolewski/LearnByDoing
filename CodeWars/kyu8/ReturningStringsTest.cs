using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/55a70521798b14d4750000a4
    [TestFixture]
    public class ReturningStringsTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ReturningStrings.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
        }
    }

    public class ReturningStrings
    {
        public static string Greet(string name) => $"Hello, {name} how are you doing today?";
    }
}
