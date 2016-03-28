using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.AbstractFactory
{
    class MetalFactory:AbstractFactory
    {
        public override ProductTypeA CreateTypeA()
        {
            return new ProductA2();
        }
        public override ProductTypeB CreateTypeB()
        {
            return new ProductB2();
        }
    }
}
