using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMTrafficLights
{
    public abstract class BaseLight:TextBox 
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public BaseLight()
        { }
    }
}
