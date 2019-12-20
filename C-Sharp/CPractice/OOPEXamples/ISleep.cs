using System;
using System.Collections.Generic;
using System.Text;

namespace OOPEXamples
{
    interface ISleep
    {
        bool isSleeping { get; }
        void ToggleSleep();
    }
}
