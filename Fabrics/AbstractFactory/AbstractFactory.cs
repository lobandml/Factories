using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract ProductTypeA CreateTypeA();
        public abstract ProductTypeB CreateTypeB();
    }
}
