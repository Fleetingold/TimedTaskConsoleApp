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
    public class CurryingReasoningTests
    {
        //Arrange
        private CurryingReasoning _curringReasoning;
        public CurryingReasoningTests()
        {
            _curringReasoning = new CurryingReasoning();
        }
        [TestMethod()]
        public void AddTwoNumberTest()
        {
            //Act
            var addTwoNumberResult = _curringReasoning.AddTwoNumber()(1, 2);

            //Assert
            Assert.AreEqual(addTwoNumberResult, 3);
        }

        [TestMethod()]
        public void AddTwoNumberCurryingTest()
        {
            //Act
            var curringResult = _curringReasoning.AddTwoNumberCurrying()(10);
            var result = curringResult(2);
            //Assert
            Assert.AreEqual(result, 12);
        }

        [TestMethod()]
        public void AddThreeNumberANDAddThreeNumberCurryingTest()
        {
            //Act
            var result1 = _curringReasoning.AddThreeNumber()(1, 2 , 3);
            var curringResult = _curringReasoning.AddThreeNumberCurrying()(1);
            var curringResult2 = curringResult(2);
            var result2 = curringResult2(3);

            //Assert
            //result1.Should().Be(6);
            //result2.Should().Be(6);
            Assert.AreEqual(result1, 6);
            Assert.AreEqual(result2, 6);
        }

        [TestMethod]
        public void Should_auto_curry_two_number_add_function()
        {
            //Arrange
            var add = _curringReasoning.AddTwoNumber();
            var addCurrying = add.Curry();

            //Act
            var result = addCurrying(1)(2);

            //Assert
            //Assert.AreEqual(result, 3);
            Assert.IsTrue(result.Should().Be(3));
        }

        [TestMethod]
        public void Should_auto_curry_three_number_add_function()
        {
            //Arrange
            var add = _curringReasoning.AddThreeNumber();
            var addCurrying = add.Curry();

            //Act
            var result = addCurrying(1)(3)(5);

            //Assert
            //Assert.AreEqual(result, 9);
            //扩展方法实现NUnit测试框架中用来书写Assert阶段的System.Int32.Should().Be(int num)
            Assert.IsTrue(result.Should().Be(9));
        }
    }
}