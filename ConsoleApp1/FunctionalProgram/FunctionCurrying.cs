using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    /// <summary>
    /// 函数柯里化（Curry）
    /// 柯里化也称作局部套用。
    /// 定义：是把接受多个参数的函数变换成接受一个单一参数(最初函数的第一个参数)的函数，
    ///       并且返回接受余下的参数且返回结果的新函数的技术
    /// </summary>
    public class CurryingReasoning {
        /// <summary>
        /// 两个数相加的函数
        /// </summary>
        /// <returns></returns>
        public Func<int, int, int> AddTwoNumber()
        {
            return (x, y) => x + y;
        }

        /// <summary>
        /// 两个数相加的函数
        /// 局部套用版本
        /// </summary>
        /// <returns></returns>
        public Func<int, Func<int, int>> AddTwoNumberCurrying()
        {
            Func<int, Func<int, int>> addCurrying = x => y => x + y;
            return addCurrying;
        }

        /// <summary>
        /// 三个数相加的函数
        /// </summary>
        /// <returns></returns>
        public Func<int, int, int, int> AddThreeNumber()
        {
            return (x, y, z) => x + y + z;
        }

        /// <summary>
        /// 三个数相加的函数
        /// 局部套用版本
        /// </summary>
        /// <returns></returns>
        public Func<int, Func<int, Func<int, int>>> AddThreeNumberCurrying()
        {
            Func<int, Func<int, Func<int, int>>> addCurring = x => y => z => x + y + z;
            return addCurring;
        }
    }
    public static class ExtensionFunctionCurrying
    {
        /// <summary>
        /// 两个数相加的函数
        /// 利用扩展方法自动局部套用：
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> func)
        {
            return x => y => func(x, y);
        }

        /// <summary>
        /// 三个数相加的函数
        /// 利用扩展方法自动局部套用：
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func)
        {
            return x => y => z => func(x, y, z);
        }

        #region 扩展方法实现NUnit测试框架中用来书写Assert阶段的System.Int32.Should().Be(int num)

        /// <summary>
        /// //实现System.Int32.Should()
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Should(this int num) {
            return num;
        }

        /// <summary>
        /// 实现System.Int32.Be(int num)
        /// </summary>
        /// <param name="num"></param>
        /// <param name="numCompare"></param>
        /// <returns></returns>
        public static bool Be(this int num, int numCompare) {
            if (num == numCompare)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
