namespace BuilderCar
{
    class Shop
    {
        IBuilder builder;

        public Shop(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Assemble()
        {
            builder.BuildCarbody();
            builder.BuildEngine();
            builder.BuildTransmission();
            builder.BuildWheels();
        }
    }
}
