using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace fakebook1.Models
{
    public class Profile
    {

        public string bioText { get; set; }

        [Key,ForeignKey("Member")]
        public int ID { get; set; }
        public Demographics demographics { get; set; }
        public List<Interest> interestList { get; set; }
        public List<Photo> photoList { get; set; }
        public virtual Member Member { get; set; }
    }
}