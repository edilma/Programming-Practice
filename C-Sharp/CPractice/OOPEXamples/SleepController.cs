using System;
using System.Collections.Generic;
using System.Text;

namespace OOPEXamples
{
    class SleepController : ISleep
     {
        public bool isSleeping { get; private set; }
        public void ToggleSleep()
        {
            isSleeping = !isSleeping;
        }
    }
}
