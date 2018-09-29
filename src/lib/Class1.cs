using System;
using log4net;

namespace spike_core2_mono5
{
    public class Class1
    {
        public Class1()
        {
            log4net.LogManager.GetLogger(typeof(Class1)).InfoFormat("Hello - logging");
        }
    }
}
