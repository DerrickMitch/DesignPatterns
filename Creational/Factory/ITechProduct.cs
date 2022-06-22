using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface ITechProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
