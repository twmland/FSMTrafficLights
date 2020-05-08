using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMTrafficLights
{
    public class TrafficLight : BaseTrafficLight
    {
        public TrafficLight(BaseTrafficLight nextLight, Color colorLightOn, int durationSeconds) : base(nextLight, colorLightOn, durationSeconds)
        {
        }
        
    }
}
