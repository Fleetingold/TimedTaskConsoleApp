using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class UserDefinedLambda
    {
        public void LambdaFun(string str, Func<string, string> func)
        {
            Console.WriteLine(func(str));
            Console.ReadKey();
        }

        public void LambdaFunTest() {
            LambdaFun("BeiJing 2013", s =>
            {
                if (s.Contains("2013"))
                {
                    s = s.Replace("2013", "2014");
                }
                return s;
            });
        }
    }
}
