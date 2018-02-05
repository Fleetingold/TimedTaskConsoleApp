using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionalProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FunctionalProgram.Tests
{
    [TestClass()]
    public class LazyEvaluationTests
    {
        [TestMethod()]
        public void NextStepTest()
        {
            LazyEvaluation lazyEvaluation = new LazyEvaluation();
            lazyEvaluation.NextStep(lazyEvaluation.MemoryUtilization(),lazyEvaluation.BigCalculatationForFirstStep());
        }

        [TestMethod()]
        public void NextStepWithOrderFunctionTest()
        {
            LazyEvaluation lazyEvaluation = new LazyEvaluation();
            lazyEvaluation.NextStepWithOrderFunction(lazyEvaluation.MemoryUtilization, lazyEvaluation.BigCalculatationForFirstStep);
        }
    }
}