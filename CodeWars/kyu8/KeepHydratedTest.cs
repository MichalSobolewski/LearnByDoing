using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/582cb0224e56e068d800003c
    [TestFixture]
    public class KeepHydratedTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(1, KeepHydrated.Litres(2));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(0, KeepHydrated.Litres(1.4));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual(6, KeepHydrated.Litres(12.3));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(0, KeepHydrated.Litres(0.82));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual(5, KeepHydrated.Litres(11.8));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual(893, KeepHydrated.Litres(1787));
        }
        [Test]
        public static void Test7()
        {
            Assert.AreEqual(0, KeepHydrated.Litres(0));
        }

    }

    public class KeepHydrated
    {
        public static int Litres(double time) => Convert.ToInt32(Math.Floor(time * 0.5));
    }
}
