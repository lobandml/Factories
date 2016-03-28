using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.FactoryMethod
{
    class MetalProduct:Product
    {
        public MetalProduct()
        {
             
        }
        public override string CheckMe()
        {
            return "Это металлическое изделие";
        }
    }
}
