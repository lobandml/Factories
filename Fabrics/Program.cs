using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory method
            FactoryMethod.Fabric[] manufacture = {new FactoryMethod.FabricA(),new FactoryMethod.FabricB()};

            FactoryMethod.Product temporaryproduct;
            temporaryproduct = manufacture[0].CreateItem();
            Console.WriteLine(temporaryproduct.CheckMe());
            temporaryproduct = manufacture[1].CreateItem();
            Console.WriteLine(temporaryproduct.CheckMe());

            //AbstractFactory

            AbstractFactory.MetalFactory metal = new AbstractFactory.MetalFactory();
            AbstractFactory.WoodenFactory wooden = new AbstractFactory.WoodenFactory();

            List<AbstractFactory.ProductTypeA> cars = new List<AbstractFactory.ProductTypeA>();
            List<AbstractFactory.ProductTypeB> tools = new List<AbstractFactory.ProductTypeB>();

            cars.Add(metal.CreateTypeA());
            cars.Add(wooden.CreateTypeA());

            tools.Add(metal.CreateTypeB());
            tools.Add(wooden.CreateTypeB());

            for (int i = 0; i < 2; i++)
            {
                cars[i].Drive();
                tools[i].Drill();
            }

            Console.ReadKey();
        }
    }
}
