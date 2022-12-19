using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Sum
    {
         NLog nlog = new NLog();
        public void DoSum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogError("a and b values are zero");
            }
            else
            {
                int c = a + b;
                nlog.LogDebug("The Program excecuting");
                nlog.LogInfo("values adding");
            }
        }
    }
}