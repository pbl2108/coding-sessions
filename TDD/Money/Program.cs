using System;
using System.Collections.Generic;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PolymorphismSample();
        }

        static void PolymorphismSample()
        {
            var list = new List<IGeometricForm>()
            {
                FormsFactory.CreateForm("circle"),
                FormsFactory.CreateForm("square"),
                FormsFactory.CreateForm("square")
            };

            foreach (IGeometricForm item in list)
            {
                item.Draw(12);
            }
        }
    }
}
