using NUnit.Framework;

namespace CodeWars.kyu7
{
    //https://www.codewars.com/kata/57f609022f4d534f05000024
    [TestFixture]
    public class FindTheStrayNumberTest
    {
        [Test]
        public void SimpleArray1()
        {
            Assert.AreEqual(2, FindTheStrayNumber.Stray(new int[] { 1, 1, 2 }));
        }
    }

    class FindTheStrayNumber
    {
        public static int Stray(int[] numbers)
        {
            var result = numbers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
            return result.First();
        }
    }
}
