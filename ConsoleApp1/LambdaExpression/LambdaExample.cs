using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    [TestClass]
    public class LambdaExample01
    {
        [TestMethod]
        public void Example01() {
            List<string> Citys = new List<string>()
            {
                "BeiJing",
                "ShangHai",
                "TianJin",
                "GuangDong"
            };
            var result = Citys.First(c => c.Length > 7);
            Assert.AreEqual(result,"ShangHai");

            // Func<T>委托 T 是参数类型，这是一个泛型类型的委托，用起来很方便的。
            Func<string, bool> predicate = c => c.Length > 7;
            int citysCount = Citys.Count(predicate);
            Assert.AreEqual(citysCount, 2);
        }


    }
}
