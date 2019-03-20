using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_UWP.SpeechClasses
{
   public static class PhRTiming
    {
        private static TimeSpan tsElapsed;
        public static TimeSpan TsElapsed
        {
            get { return tsElapsed; }
            set { tsElapsed = value; }
        }
    }
}
