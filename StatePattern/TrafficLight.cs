using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TrafficLight
    {
        private ITrafficLight? currentState;

        public TrafficLight()
        {
            currentState = new RedLightState();
        }
        public void SetState(ITrafficLight? state)
        {
            currentState=state;
        }
        public void ChangeState()
        {
            currentState!.Handle(this);
        }
    }
}
