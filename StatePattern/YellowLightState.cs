using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class YellowLightState:ITrafficLight
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow Light Wait!!!");
            trafficLight.SetState(new RedLightState());
        }
    }
}
