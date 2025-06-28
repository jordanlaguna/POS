using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.model
{
    public class BillsModel
    {
        public string? Number { get; set; }
        public DateTime Date_now { get; set; }
        public List<BillsProduct> Product { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public string? Pay_method { get; set; }
        public decimal Total { get; set; }
        public decimal Cash { get; set; }
        public decimal Change { get; set; }
    }
}
