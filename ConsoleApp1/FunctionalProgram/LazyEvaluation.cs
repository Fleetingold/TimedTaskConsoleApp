using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FunctionalProgram
{
    public class LazyEvaluation
    {
        private bool FirstStepExecuted;

        public double MemoryUtilization()
        {
            //计算目前内存使用率
            var pcInfo = new ComputerInfo();
            var usedMem = pcInfo.TotalPhysicalMemory - pcInfo.AvailablePhysicalMemory;
            return (double)(usedMem / Convert.ToDecimal(pcInfo.TotalPhysicalMemory));
        }

        public int BigCalculatationForFirstStep()
        {
            //第一步运算
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("big calulation");
            FirstStepExecuted = true;
            return 10;
        }

        public void NextStep(double memoryUtilization, int firstStepDistance)
        {
            //下一步运算
            if (memoryUtilization < 0.8 && firstStepDistance < 100)
            {
                Console.WriteLine("Next step");
            }
        }

        public void NextStepWithOrderFunction(Func<double> memoryUtilization, Func<int> firstStep)
        {
            if (memoryUtilization() < 0.8 && firstStep() < 100)
            {
                Console.WriteLine("Next step");
            }
        }
    }
}