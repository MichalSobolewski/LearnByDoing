using NUnit.Framework;

namespace CodeWars.kyu8
{
    //https://www.codewars.com/kata/57356c55867b9b7a60000bd7
    [TestFixture]
    public class BasicMathematicalOperationsTest
    {
        [Test]
        public void StaticTests()
        {
            Assert.AreEqual(BasicMathematicalOperations.basicOp('+', 4, 7), 11);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('-', 15, 18), -3);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('*', 5, 5), 25);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('/', 49, 7), 7);
        }
    }

    public class BasicMathematicalOperations
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            double result = 0.0;
            switch (operation)
            {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '/':
                    result = value1 / value2;
                    break;
            }

            return result;
        }
    }
}
