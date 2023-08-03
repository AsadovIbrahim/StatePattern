namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.ChangeState();
            trafficLight.ChangeState();
            trafficLight.ChangeState();
            trafficLight.ChangeState();
        }
    }
}