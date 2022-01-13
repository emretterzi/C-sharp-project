using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kargoTakip
{
    class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public Location customerLocation { get; set; }
        public int cargoId { get; set; }
        public bool situation { get; set; }
    }
}
