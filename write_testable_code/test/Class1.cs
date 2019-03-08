using System;
using Xunit;
using System.Diagnostics;
using ThisCalc.Easy;

namespace test
{

    public class Class1
    {
        
        [Fact]
        public void testGetTotalShouldReturnTotalPrice()
        {
           Calculator _calculator = new Calculator();
            //action
            var result = _calculator.GetTotal(1.00m, 2.00m, 0.50m);
            decimal expected = 2.50m;
            //assert
            Assert.Equal(expected, result);
        }
    }
}
