// <copyright file="IntelliTestDemo01Test.cs">Copyright ©  2017</copyright>
using System;
using IntelliTestDemo;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntelliTestDemo.Tests
{
    /// <summary>此类包含 IntelliTestDemo01 的参数化单元测试</summary>
    [PexClass(typeof(IntelliTestDemo01))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class IntelliTestDemo01Test
    {
        /// <summary>测试 RandomMethod() 的存根</summary>
        [PexMethod]
        public void RandomMethodTest([PexAssumeUnderTest]IntelliTestDemo01 target)
        {
            target.RandomMethod();
            // TODO: 将断言添加到 方法 IntelliTestDemo01Test.RandomMethodTest(IntelliTestDemo01)
            Assert.IsNotNull(target);
        }
    }
}
