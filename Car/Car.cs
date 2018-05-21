using System;
using System.Collections;

namespace BuilderCar
{
    public class Car
    {
        public String Name { get; set; }
        public Car(String name) { Name = name; }
        ArrayList parts = new ArrayList();

        public void Add(Object part)
        {
            parts.Add(part);
        }

        public void Issue()
        {
            Console.WriteLine(Name);
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
