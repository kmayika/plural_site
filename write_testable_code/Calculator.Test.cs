using System;
using NUnit;
using Xunit;
using ThisCalc.Easy;

namespace ThisTest.Easy
{
    
    
    public class CalculatorTests
    {
        //subject under test
        private Calculator _calculator;
        //Method run in each and every run to ensure that the test is setup properly
        [Fact]
        public void SetUp()
        {
            //calc class initialised before every test
            _calculator = new Calculator();
        }
        //test method
        [Fact]
        public void testGetTotalShouldReturnTotalPrice()
        {
            //action
            var result = _calculator.GetTotal(1.00m, 2.00m, 0.50m);
            decimal expected = 2.50m;
            //assert
            Assert.Equal(expected, result);
        }
    }

}
