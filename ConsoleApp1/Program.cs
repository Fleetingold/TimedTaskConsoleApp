using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimedTask;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cron表达式 参考 http://www.cnblogs.com/sunjie9606/archive/2012/03/15/2397626.html
            //每隔5秒执行一次这个方法
            QuartzManager.AddJob<MyJob>("每隔5秒", "*/5 * * * * ?");
        }
    }
}
