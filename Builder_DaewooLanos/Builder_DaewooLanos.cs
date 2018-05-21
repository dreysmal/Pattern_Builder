namespace BuilderCar
{
    public class Builder_DaewooLanos : IBuilder
    {
        Car car = new Car("Daewoo Lanos");

        public void BuildCarbody()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "Седан");
        }

        public void BuildEngine()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + 98);
        }

        public void BuildTransmission()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "5 Manual");
        }

        public void BuildWheels()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + 13);
        }

        public Car Get_a_new_Car()
        {
            return car;
        }
    }
}
