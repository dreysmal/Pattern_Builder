namespace BuilderCar
{
    public class Builder_FordProbe : IBuilder
    {
        Car car = new Car("Ford Probe");

        public void BuildCarbody()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "Купе");
        }

        public void BuildEngine()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + 160);
        }

        public void BuildTransmission()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "4 Auto");
        }

        public void BuildWheels()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + 14);
        }

        public Car Get_a_new_Car()
        {
            return car;
        }
    }
}
