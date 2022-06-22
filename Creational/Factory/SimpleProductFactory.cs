using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SimpleProductFactory
    {
        public ITechProduct CreateProduct(string id)
        {
            switch (id)
            {
                case "phone":
                    return new Phone();
                case "tablet":
                    return new Tablet();
                case "laptop":
                    return new Laptop();
                default:
                    return null;
            }
        }
    }
}
