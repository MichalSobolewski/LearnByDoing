using NUnit.Framework;

namespace CodeWars.kyu8
{
    [TestFixture]
    public class TrafficLightTest
    {
        [TestCase("green", "yellow")]
        [TestCase("yellow", "red")]
        [TestCase("red", "green")]
        public void BasicTests(string s, string expected)
        {
            Assert.That(TrafficLight.UpdateLight(s), Is.EqualTo(expected));
        }
    }

    public class TrafficLight
    {
        public static string UpdateLight(string current)
        {
            var result = current switch
            {
                "green" => "yellow",
                "yellow" => "red",
                "red" => "green",
                _ => "Something went wrong!"
            };

            return result;
        }
    }
}
