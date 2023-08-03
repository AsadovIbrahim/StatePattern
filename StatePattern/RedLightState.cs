using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class RedLightState : ITrafficLight
    {
        public void Handle(TrafficLight trafficLight)
        {
            Console.WriteLine("Red Light Stop!!!");
            trafficLight.SetState(new GreenLightState());
        }
    }
}
