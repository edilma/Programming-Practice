using System;
using System.Collections.Generic;
using System.Text;

namespace OOPEXamples
{
    interface IPowerOn
    {
        bool isOn { get;  }
        void TogglePower();
    }
}
