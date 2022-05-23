using NUnit.Framework;

namespace CodeWars.kyu6
{
    //https://www.codewars.com/kata/54da5a58ea159efa38000836
    [TestFixture]
    public class FindTheOddIntTest
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(5, FindTheOddInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }

    public class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            var result = 0;
            for (var i = 0; i < seq.Length; i++)
            {
                result = result ^ seq[i];
            }

            return result;
        }
    }
}
