using System;
using System.Collections.Generic;
using System.Text;

namespace App1.models
{
    class reqres
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total_pages { get; set; }

        public List<user> data { get; set; }

        //public string support { get; set; }
    }
}
