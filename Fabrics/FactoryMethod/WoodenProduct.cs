using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fabrics.FactoryMethod
{
    class WoodenProduct:Product
    {
        public WoodenProduct()
        {

        }
        public override string CheckMe()
        {
            return "Это деревянное изделие";
        }
    }
}
