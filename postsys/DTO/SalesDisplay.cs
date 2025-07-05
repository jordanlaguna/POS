using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.DTO
{
    public class SalesDisplay
    {
        public string SaleNumber { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }
        public decimal Total { get; set; }
    }

}
