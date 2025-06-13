using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.model
{
    internal class Person
    {
        public int id_person { get; set; }
        public DateTime birth_date { get; set; }
        public string identification { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string secondName { get; set; }
        public string telephone { get; set; }
        public int id_user { get; set; }
        public string email { get; set; }

    }
}
