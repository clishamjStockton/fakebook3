using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fakebook1.Models
{
    public class Friend
    {
        [Key]
        public int friendID { get; set; }
        public int memberReference { get; set; }
        public DateTime dateFriended { get; set; }

    }
}