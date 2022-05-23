using NUnit.Framework;

namespace CodeWars.kyu7
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SimpleArray1()
        {
            Assert.AreEqual(2, Solution.Stray(new int[] { 1, 1, 2 }));
        }
    }

    class Solution
    {
        public static int Stray(int[] numbers)
        {
            var result = numbers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
            return result.First();
        }
    }
}
