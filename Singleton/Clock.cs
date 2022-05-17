using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    internal class Clock
    {
        private static Clock clockInstance;
        private static readonly object key = new object();

        private Clock()
        {
           
        }
        public static Clock GetInstance()
        {
            if (clockInstance == null)
            {
                lock (key)
                {
                    if (clockInstance == null)
                        clockInstance = new Clock();
                }
            }
            return clockInstance;
        }
        public DateTime GetTime()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime;
        }
    }
}
