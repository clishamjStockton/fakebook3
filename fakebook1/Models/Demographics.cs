using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fakebook1.Models
{
    public class Demographics
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public int demographicID { get; set; }
    }
}