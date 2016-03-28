using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.AbstractFactory
{
    class WoodenFactory:AbstractFactory
    {
        public override ProductTypeA CreateTypeA()
        {
            return new ProductA1();
        }
        public override ProductTypeB CreateTypeB()
        {
            return new ProductB1();
        }
    }
}
