using NUnit.Framework;

namespace CodeWars.kyu6
{
    //https://www.codewars.com/kata/54e6533c92449cc251001667
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", UniqueInOrderTest.UniqueInOrder(""));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", UniqueInOrderTest.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }

    public class UniqueInOrderTest
    {
        public static IEnumerable<T> UniqueInOrder1<T>(IEnumerable<T> iterable)
        {
            var uniques = new List<T>();

            if (!iterable.Any())
            {
                return uniques;
            }

            var firstItem = iterable.First();
            uniques.Add(firstItem);

            foreach (var item in iterable)
            {
                if (item!.Equals(firstItem))
                {
                    continue;
                }
                firstItem = item;
                uniques.Add(item);
            }

            return uniques;
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T currentItem = default!;

            foreach (var item in iterable)
            {
                if (item!.Equals(currentItem))
                {
                    continue;
                }
                currentItem = item;

                yield return currentItem;
            }
        }
    }
}
