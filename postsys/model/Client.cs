using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.model
{
    internal class Client
    {
        public int id_client { get; set; }
        public string identification { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string second_name {get; set; }
        public string email { get; set; }
        public int telephone { get; set; }
        public string address { get; set; }
        public DateTime register_date { get; set; }
    }
}
