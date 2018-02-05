using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    delegate int del(int i);
    class LambdaExpressionTree
    {
        static void DeclareExpressionTree(string[] args)
        {
            Expression<del> myET = x => x * x;
        }
    }
}
