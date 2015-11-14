using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace fakebook1.Models
{
    public class Member
    {

        public string userName { get; set; }
        public string displayName { get; set; }
        [DataType(DataType.Date)]
        public DateTime datedJoined { get; set; }
        [DataType(DataType.Date)]
        public DateTime lastLogin { get; set; }
        [Key]
        public int ID { get; set; }

        public Profile Profile { get; set; }
        public List<Friend> friendList { get; set; }
        public List<Message> messageList { get; set; }
    }
}