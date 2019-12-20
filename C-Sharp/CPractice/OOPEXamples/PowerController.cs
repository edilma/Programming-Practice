using System;
using System.Collections.Generic;
using System.Text;

namespace OOPEXamples
{
    class PowerController: IPowerOn
    {
        public bool isOn { get; private set; }
        protected void TurnOn()
        {
            isOn = true;
        }
        protected void TurnOff()
        {
            isOn = false;
        }
        public virtual void TogglePower()
        {
            if (isOn == true)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}
