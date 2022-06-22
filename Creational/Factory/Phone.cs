using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Phone : ITechProduct
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Phone";
    }
}
