using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.AbstractFactory
{
    class ProductB1:ProductTypeB
    {
        public override void Drill()
        {
            Console.WriteLine("Wooden tool");
        }
    }
}
