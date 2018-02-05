using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class ReviewDelegate
    {
        // 委托类型
        delegate int calculator(int x, int y);
        static void NotMain()
        {
            calculator cal = new calculator(Adding);
            int He = cal(1, 1);
            Console.Write(He);
        }

        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int Adding(int x, int y)
        {
            //throw new NotImplementedException();
            return x + y;
        }
    }

    class DelegateWithAnonymousMethod
    {
        // 委托类型
        delegate int calculator(int x, int y); // 委托
        static void NotMain()
        {
            calculator cal = delegate (int num1, int num2)
            {
                return num1 + num2;
            };
            int He = cal(1, 1);
            Console.Write(He);
        }
    }

    class DelegateWithLambdaExpression
    {
        // 委托类型
        delegate int calculator(int x, int y); // 委托
        static void NotMain()
        {
            calculator cal = (x, y) => x + y;// Lambda表达式，大家发现没有，代码一个比一个简洁

            int He = cal(1, 1);
            Console.Write(He);
        }
    }

    class SimpleLambdaExpression {
        delegate bool MyBol(int x, int y);
        delegate bool MyBol_2(int x, string y);
        delegate int calculator(int x, int y); //委托类型
        delegate void VS();
        // 自己建的委托
        delegate bool MyDele(People p);
        static void NotMain()
        {
            MyBol Bol = (x, y) => x == y;
            MyBol_2 Bol_2 = (x, s) => s.Length > x;
            calculator C = (X, Y) => X * Y;
            VS S = () => Console.Write("我是无参数Labada表达式");
            //
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            //
            List<People> people = LoadData();//初始化

            // 分解
            // 自己建的委托 delegate bool MyDele(People p);
            // 使用委托
            MyDele myDele = p => p.age > 20;
            // C#内置泛型委托  delegate TResult System.Func<int T, out TResult>(T arg)
            Func<People, bool> predicate = p => p.age > 20;

            IEnumerable<People> results2 = people.Where(predicate);

            // 委托的实例化：使用匿名方法 
            // < 委托类型 > < 实例化名 >= delegate (< 函数参数 >){ 函数体};
            Func<People, bool> predicate2 = delegate (People p) { return p.age > 20; };
            IEnumerable<People> results4 = people.Where(predicate2);

            IEnumerable<People> results = people.Where(delegate (People p) { return p.age > 20; });
            // 更简便的写法
            IEnumerable<People> results3 = people.Where(p => p.age > 20);
        }

        private static List<People> LoadData()
        {
            List<People> people = new List<People>();   //创建泛型对象  
            People p1 = new People(21, "guojing");       //创建一个对象  
            People p2 = new People(21, "wujunmin");     //创建一个对象  
            People p3 = new People(20, "muqing");       //创建一个对象  
            People p4 = new People(23, "lupan");        //创建一个对象  
            people.Add(p1);                     //添加一个对象  
            people.Add(p2);                     //添加一个对象  
            people.Add(p3);                     //添加一个对象  
            people.Add(p4);
            return people;
        }

    }

    public class People
    {
        public int age { get; set; }                //设置属性  
        public string name { get; set; }            //设置属性  
        public People(int age, string name)      //设置属性(构造函数构造)  
        {
            this.age = age;                 //初始化属性值age  
            this.name = name;               //初始化属性值name  
        }
    }

    public class FuncDelegateExample1
    {
        static void NotMain(string[] args)
        {
            Func<int, string> gwl = p => p + 10 + "--返回类型为string";
            Console.WriteLine(gwl(10) + "");  //打印‘20--返回类型为string',z对应参数b，p对应参数a
            Console.ReadKey();
        }
    }

    public class FuncDelegateExample2
    {
        static void NotMain(string[] args)
        {
            Func<int, int, bool> gwl = (p, j) =>
            {
                if (p + j == 10)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(gwl(5,5) + "");  //打印'True',z对应参数b,p对应参数a
            Console.ReadKey();
        }
    }
}

