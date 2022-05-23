using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/57a429e253ba3381850000fb
    [TestFixture]
    public class CalculateBmiTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Normal", CalculateBmi.Bmi(80, 1.80));
        }
        private static Random rnd = new Random();

        private static string Solution(double w, double h)
        {
            double r = w / (h * h);
            return (r > 30) ? "Obese" : (r > 25) ? "Overweight" : (r > 18.5) ? "Normal" : "Underweight";
        }

        [Test, Description("Fixed Tests")]
        public void FixedTest()
        {
            Action[] tests = new Action[]
            {
                () => Assert.AreEqual("Underweight", CalculateBmi.Bmi(50, 1.80)),
                () => Assert.AreEqual("Normal", CalculateBmi.Bmi(80, 1.80)),
                () => Assert.AreEqual("Overweight", CalculateBmi.Bmi(90, 1.80)),
                () => Assert.AreEqual("Obese", CalculateBmi.Bmi(110, 1.80)),
            };
            tests.OrderBy(x => rnd.Next()).ToList().ForEach(a => a.Invoke());
        }

        [Test, Description("Random Tests")]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                double weight = rnd.NextDouble() * 250 + 50;
                double height = rnd.NextDouble() * 2.5 + 0.5;
                string expected = Solution(weight, height);
                string actual = CalculateBmi.Bmi(weight, height);
                Assert.AreEqual(expected, actual);
            }
        }
    }

    public class CalculateBmi
    {
        public static string Bmi(double weight, double height)
        {

            var bmi = weight / Math.Pow(height, 2);
            var result = bmi switch
            {
                <= 18.5 => "Underweight",
                > 18.5 and <= 25.0 => "Normal",
                > 25.0 and <= 30.0 => "Overweight",
                > 30 => "Obese",
                _ => "Something went wrong!"
            };

            return result;
        }
    }
}
