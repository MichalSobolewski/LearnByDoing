using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/544675c6f971f7399a000e79
    [TestFixture]
    public class ConvertStringToNumberTest
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(1234, ConvertStringToNumber.StringToNumber("1234"));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(605, ConvertStringToNumber.StringToNumber("605"));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(1405, ConvertStringToNumber.StringToNumber("1405"));
        }

        [Test]
        public void test4()
        {
            Assert.AreEqual(-7, ConvertStringToNumber.StringToNumber("-7"));
        }
    }

    public class ConvertStringToNumber
    {
        public static int StringToNumber(String str)
        {
            return Convert.ToInt32(str);
        }
    }
}
