using NUnit.Framework;

namespace CodeWars.kyu6
{
    //https://www.codewars.com/kata/5264d2b162488dc400000001
    [TestFixture]
    public class StopgninnipSMysdroWTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", StopgninnipSMysdroW.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", StopgninnipSMysdroW.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", StopgninnipSMysdroW.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", StopgninnipSMysdroW.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", StopgninnipSMysdroW.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", StopgninnipSMysdroW.SpinWords("Just kidding there is still one more"));
        }
    }

    public class StopgninnipSMysdroW
    {
        public static string SpinWords(string sentence)
        {
            var wordsList = sentence.Split(' ').ToList();
            var result = "";

            foreach (var word in wordsList)
            {
                if (wordsList.Count == 1)
                {
                    result += new string(word.Reverse().ToArray());
                    break;
                }

                if (word.Length >= 5)
                {
                    result += $"{ new string(word.Reverse().ToArray()) } ";
                }
                else
                {
                    result += $"{ word } ";
                }
            }

            if (wordsList.Count > 1)
            {
                result = result.Remove(result.Length - 1);
            }

            return result;
        }
    }
}
