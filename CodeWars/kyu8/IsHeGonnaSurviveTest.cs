using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/59ca8246d751df55cc00014c/csharp
    [TestFixture]
    class IsHeGonnaSurviveTest
    {
        [TestCase(10, 5)]
        [TestCase(100, 40)]
        public void ATrueHero(int bullets, int dragons)
        {
            Assert.IsTrue(IsHeGonnaSurvive.Hero(bullets, dragons));
        }

        [TestCase(4, 5)]
        [TestCase(1500, 751)]
        [TestCase(0, 1)]
        [TestCase(7, 4)]
        public void AFalseHero(int bullets, int dragons)
        {
            Assert.IsFalse(IsHeGonnaSurvive.Hero(bullets, dragons));
        }
    }

    class IsHeGonnaSurvive
    {
        public static bool Hero(int bullets, int dragons) => bullets >= dragons * 2;
    }
}
