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

        [TestMethod]
        [DynamicData(nameof(SingleNumberGenerator), DynamicDataSourceType.Method)]
        public void DivideTwoNumbersThatAreTheSame(int value)
        {
            var result = Calculator.Divide(value, value);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(10, 2, 5)]
        [DataRow(20, 5, 4)]
        public void DivideTwoNumbersThatAreNotTheSame(int lvalue, int rvalue, int expected)
        {
            var result = Calculator.Divide(lvalue, rvalue);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(4, 0)]
        [DataRow(0, 0)]
        public void ThrowADivideByZeroExceptionWhenDividingByZero(int lvalue, int rvalue)
        {
            // var result = Calculator.Divide(4, 0);
            Assert.ThrowsException<DivideByZeroException>(() => { Calculator.Divide(4, 0); });
        }

        [TestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 10)]
        public void MustReturnADoubleDataType(int lvalue, int rvalue)
        {
            var result = Calculator.Divide(lvalue, rvalue);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        public static IEnumerable<object[]> SingleNumberGenerator()
        {
            List<object[]> result = new List<object[]>();


            for (int i = 1; i < 1000; i++)
            {
                result.Add(new object[] { i });
            }

            return result;
        }


    }
}
