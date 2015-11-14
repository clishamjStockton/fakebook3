using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fakebook1.Models
{
    public class Message
    {

        public Member recipient { get; set; }
        [Key]
        public int messageID { get; set; }
        public string messageText { get; set; }
        public DateTime dateSent { get; set; }
        public Boolean read { get; set; }
        public int threadID { get; set; }
    }
}