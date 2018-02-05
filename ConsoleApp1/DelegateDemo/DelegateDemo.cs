using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.DelegateDemo
{
    class DelegateDemo01
    {
        //声明委托
        delegate int MyDelegate(int x, int y);

        static void MainDelegate(string[] args)
        {
            //1、Action<T>只能委托必须是无返回值的方法
            Action<string> _action = new Action<string>(SayHello);
            _action("Hello World");

            //2、Fun<TResult>只能委托必须有返回值的方法
            Func<int, bool> _func = new Func<int, bool>(Check);
            _func(5);

            //3、Predicate:此委托返回一个bool值，该委托通常引用一个"判断条件函数"。
            //需要指出的是，判断条件一般为“外部的硬性条件”,比如“大于50”，
            //而不是由数据自身指定，如“查找数组中最大的元素就不适合”。
            Predicate<int> _predicate = new Predicate<int>(Check);

            //使用Lambda表达式
            Predicate<int> predicate = p => p % 2 == 0;
            _predicate(26);
        }

        //返回值为bool值
        private static bool Check(int i)
        {
            //throw new NotImplementedException();
            if (i % 2 == 0)
            {
                return true;
            }
            return false;
        }

        private static void SayHello(string strMsg)
        {
            //throw new NotImplementedException();
            Console.WriteLine(strMsg);
        }
    }

    class DelegateDemo02
    {
        //声明委托
        delegate int MyDelegate(int x, int y);

        static void MainDelegate(string[] args)
        {
            MyDelegate _myDelegate = new MyDelegate(fun1);
            _myDelegate += fun2;
            Console.WriteLine(_myDelegate(10, 23));
            Console.ReadKey();//输出10，返回最后一个注册函数的返回值
        }

        private static int fun2(int x, int y)
        {
            //throw new NotImplementedException();
            return x + y;
        }

        private static int fun1(int x, int y)
        {
            //throw new NotImplementedException();
            return x;
        }
    }
}
