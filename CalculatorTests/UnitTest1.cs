using NUnit.Framework;
using CalculatorModel;

namespace CalculatorTests
{
    public class IntegerCalc_Tests
    {
        public class SimpleCalculations
        {
            Calculator _calculator;
            [SetUp]
            public void Setup()
            {
                _calculator = new Calculator();
            }
            public void WhenSetupWithTWoDoubles_Add_ReturnsCorrectAnswer()
            {
                _calculator.Num1 = 2.5;
                _calculator.Num2 = 7.4;

                Assert.That(_calculator.Add(), Is.EqualTo(9.9));
            }
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}