using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsys.services
{
    public static class AuthSession
    {
        public static string? AccessToken { get; set; }
        public static int UserId { get; set; }
    }

}
