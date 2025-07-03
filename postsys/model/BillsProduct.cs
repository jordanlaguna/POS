using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.model
{
    public class BillsProduct
    {
        public int id_product { get; set; } 
        public string? name { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    }

}
