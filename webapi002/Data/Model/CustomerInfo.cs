using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi002.Data.Model
{
    public class CustomerInfo
    {
        public int id { get; set; }
        public string name { get; set;  }
        public string lname { get; set; }
        public string address { get; set; }
        public string?  city { get; set; }
        public DateTime? birthday { get; set;  }

    }
}
