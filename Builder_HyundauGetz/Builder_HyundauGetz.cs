
namespace BuilderCar
{
    public class Builder_HyundauGetz : IBuilder
    {
        Car car = new Car("Hyundai Getz");

        public void BuildCarbody()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "Хетчбэк");
        }

        public void BuildEngine()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + 66);
        }

        public void BuildTransmission()
        {
            car.Add(System.Reflection.MethodBase.GetCurrentMethod().Name.Remove(0, 5) + "\t" + "4 Auto");
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
