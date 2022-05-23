using NUnit.Framework;

namespace CodeWars.kyu7
{
    //https://www.codewars.com/CategorizeNewMember/5502c9e7b3216ec63c0001aa
    [TestFixture]
    public class CategorizeNewMemberTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, CategorizeNewMember.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, CategorizeNewMember.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, CategorizeNewMember.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
        }

    }

    public class CategorizeNewMember
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(x =>
            {
                return (x[0] >= 55 && x[1] > 7) ? "Senior" : "Open";
            });
        }
    }
}
