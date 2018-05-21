namespace BuilderCar
{
    public class Buider_UAZPatriot : IBuilder
    {
        Car car = new Car("UAZ Patriot");

        public void BuildCarbody()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "Универсал");
        }

        public void BuildEngine()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + 120);
        }

        public void BuildTransmission()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "4 Manual");
        }

        public void BuildWheels()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + 16);
        }

        public Car Get_a_new_Car()
        {
            return car;
        }
    }
}
