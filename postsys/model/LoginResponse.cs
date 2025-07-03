using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.model
{
    public class LoginResponse
    {
        public string? access_token { get; set; }
        public string? token_type { get; set; }
        public int user_id { get; set; }
    }

}
