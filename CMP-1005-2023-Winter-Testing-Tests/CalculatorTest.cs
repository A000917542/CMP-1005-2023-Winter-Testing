using CMP_1005_2023_Winter_Testing;

namespace CMP_1005_2023_Winter_Testing_Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            var result = Calculator.Add(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}