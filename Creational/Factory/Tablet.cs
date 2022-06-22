using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Tablet : ITechProduct
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Tablet";
    }
}
