using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.FactoryMethod
{
    class FabricB:Fabric
    {
        public override Product CreateItem()
        {
            return new WoodenProduct();
        }
    }
}
