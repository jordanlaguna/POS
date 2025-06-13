using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.model
{
    internal class Product
    {
        public int id_product { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public string barcode { get; set; }
        public DateTime created_at { get; set; }
        public int category_id { get; set; }
}
}
