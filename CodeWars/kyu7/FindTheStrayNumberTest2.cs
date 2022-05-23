using NUnit.Framework;

namespace CodeWars.kyu7
{
    [TestFixture]
    public class FindTheStrayNumberTest2
    {
        [Test]
        public void SimpleArray1()
        {
            Assert.AreEqual(2, FindTheStrayNumber2.Stray(new int[] { 1, 1, 2 }));
        }
    }

    public class FindTheStrayNumber2
    {
        public static int Stray(int[] numbers)
        {
            return numbers.First(x => numbers.Count(c => c == x) == 1);
        }
    }
}
