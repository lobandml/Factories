using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.FactoryMethod
{
    abstract class Fabric
    {
        public abstract Product CreateItem();
    }
}
