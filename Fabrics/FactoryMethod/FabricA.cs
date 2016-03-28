using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.FactoryMethod
{
    class FabricA:Fabric
    {
        public override Product CreateItem()
        {
            return new MetalProduct();
        }
    }
}
