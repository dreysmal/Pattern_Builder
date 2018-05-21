namespace BuilderCar
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new Builder_DaewooLanos();
            getCar(builder);
            builder = new Builder_FordProbe();
            getCar(builder);
            builder = new Buider_UAZPatriot();
            getCar(builder);
            builder = new Builder_HyundauGetz();
            getCar(builder);

        }

        static public void getCar(IBuilder builder)
        {
            Shop shop = new Shop(builder);
            shop.Assemble();
            Car car = builder.Get_a_new_Car();
            car.Issue();
        }
    }
}
