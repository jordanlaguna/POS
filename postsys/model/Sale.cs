using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.model
{
    public class Sale
    {
        public int id { get; set; }
        public string? sale_number { get; set; }
        public DateTime created_at { get; set; }
        public string? payment_method { get; set; }
        public decimal total { get; set; }

    }
}
