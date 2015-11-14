using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fakebook1.Models
{
    public class Photo
    {

        [Key]
        public int photoID { get; set; }
        public string filePath { get; set; }
        public string description { get; set; }
        public DateTime dateAdded { get; set; }
        public Boolean profilePicture { get; set; }

    }
}