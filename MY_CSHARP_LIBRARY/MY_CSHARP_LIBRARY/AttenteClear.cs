using System;
using System.Collections.Generic;
using System.Text;

namespace MY_CSHARP_LIBRARY
{
    public class AttenteClear
    {
        public static void SleepClear(int timeToWait)
        {
            System.Threading.Thread.Sleep(timeToWait);
            Console.Clear();
        }
    }
}
