using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/54edbc7200b811e956000556[TestFixture]
    public class CountSheepsTests
    {
        [Test]
        public void SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, CountingSheep.CountSheeps(sheeps));
        }
    }

    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps) => sheeps.Count(x => x);
    }
}
