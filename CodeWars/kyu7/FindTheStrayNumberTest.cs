using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var numberGroups = numbers.GroupBy(x => x);
            var result = numberGroups.Where(x => x.Count() == 1).Select(x => x.Key);
            return 0;
        }
    }
}
