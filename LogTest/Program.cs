using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogTest
{
    
    internal class Program
    {
        private static ProcessLog log;
        static void Main(string[] args)
        {
            log = new ProcessLog();
            uint titleIndex = 0;
            uint content = 0;
            uint expindex = 0;
            while (true)
            {
                try
                {
                    expindex++;
                    if (expindex % 10 == 0)
                        throw new Exception();
                    log.Log($"Title：{titleIndex++}", $"Content：{content++}", null);
                }
                catch (Exception exp)
                {
                    log.Log($"Title：{titleIndex++}", $"Content：{content++}", exp);
                }
                    Thread.Sleep(100);

            }
        }
    }
}
