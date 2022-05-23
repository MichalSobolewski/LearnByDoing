using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/56dec885c54a926dcd001095
    [TestFixture]
    public class OppositeNumberTest
    {
        [Test]
        public void Test_1()
        {
            Assert.AreEqual(-1, OppositeNumber.Opposite(1));
        }
    }

    public class OppositeNumber
    {
        public static int Opposite(int number)
        {
            return number * -1;
        }
    }
}
