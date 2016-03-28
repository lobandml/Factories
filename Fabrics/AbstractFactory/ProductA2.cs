using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.AbstractFactory
{
    class ProductA2:ProductTypeA
    {
        public override void Drive()
        {
            Console.WriteLine("Metal car");
        }
    }
}
