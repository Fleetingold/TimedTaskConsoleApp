using Quartz;
using System;

namespace TimedTask
{
    class TimedTaskDemo
    {
       
    }

    [PersistJobDataAfterExecution]
    [DisallowConcurrentExecution]
    public class MyJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("\nWhat is your name? ");
            //var name = Console.ReadLine();
            //var date = DateTime.Now;
            //Console.WriteLine($"\nHello,{name}, on {date:d} at {date:t}!");
            //Console.Write("\nPress any key to exit ...");
            //Console.ReadKey(true);
        }
    }

}
