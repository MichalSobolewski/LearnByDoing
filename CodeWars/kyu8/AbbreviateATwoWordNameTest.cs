using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3
    [TestFixture]
    public class AbbreviateATwoWordNameTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("S.H", AbbreviateATwoWordName.AbbrevName("Sam Harris"));
            Assert.AreEqual("P.F", AbbreviateATwoWordName.AbbrevName("Patrick Feenan"));
            Assert.AreEqual("E.C", AbbreviateATwoWordName.AbbrevName("Evan Cole"));
            Assert.AreEqual("P.F", AbbreviateATwoWordName.AbbrevName("P Favuzzi"));
            Assert.AreEqual("D.M", AbbreviateATwoWordName.AbbrevName("David Mendieta"));
        }
    }

    public class AbbreviateATwoWordName
    {
        public static string AbbrevName(string name)
        {
            var result = "";

            String[] tmp = name.Split(' ');
            for (var i = 0; i < tmp.Length; i++)
            {
                result += tmp[i].Substring(0, 1);
            }

            return result.Insert(1, ".").ToUpper();
        }
    }
}
