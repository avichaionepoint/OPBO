using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPBO.CoreBuisiness
{
    public class OrderItem
    {
        public int LineNumber { get; set; }
        public string Name { get; set; }

        public double Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal Total{ get; set; }

    }
}
