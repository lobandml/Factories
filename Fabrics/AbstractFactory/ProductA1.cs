using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.AbstractFactory
{
    class ProductA1:ProductTypeA
    {
        public override void Drive()
        {
            Console.WriteLine("Wooden car");
        }
    }
}
