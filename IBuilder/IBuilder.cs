
namespace BuilderCar
{
    public interface IBuilder
    {
        void BuildCarbody();
        void BuildEngine();
        void BuildWheels();
        void BuildTransmission();
        Car Get_a_new_Car();
    }
}
