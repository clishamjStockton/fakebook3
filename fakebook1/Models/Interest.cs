using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fakebook1.Models
{
    public class Interest
    {

        public string name { get; set; }
        public string description { get; set; }
        [Key]
        public int interestID { get; set; }
    }
}