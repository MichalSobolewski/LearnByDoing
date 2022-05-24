using NUnit.Framework;

namespace CodeWars.kyu6
{
    //https://www.codewars.com/kata/54e6533c92449cc251001667
    [TestFixture]
    public class UniqueInOrderTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", UniqueInOrder.UniqueInOrder2(""));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", UniqueInOrder.UniqueInOrder2("AAAABBBCCDAABBB"));
        }
    }

    public class UniqueInOrder
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

        public static IEnumerable<T> UniqueInOrder2<T>(IEnumerable<T> iterable)
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
