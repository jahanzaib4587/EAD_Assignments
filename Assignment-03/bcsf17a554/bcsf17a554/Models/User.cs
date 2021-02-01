using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bcsf17a554.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string newpassword { get; set; }
        public string image { get; set; }
        public bool admin { get; set; }
    }
}
