using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionalProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram.Tests
{
    [TestClass()]
    public class OrderFunctionTests
    {
        [TestMethod()]
        public void Should_calculate_propertyFee_for_two_area()
        {
            //Arrange
            var calculator = new PropertyFeeCalculator();
            //Act
            var feeForBusiness = calculator.PropertyFee(2m, calculator.SquareForBusiness(2, 2));
            var feeForCivil = calculator.PropertyFee(1m,calculator.SquareForCivil(2, 2));
            //Assert
            Assert.AreEqual(feeForBusiness, 9.6m);
            Assert.AreEqual(feeForCivil, 4m);
        }
    }
}