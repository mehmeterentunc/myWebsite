using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myWebsite.Models.classes
{
    public class Web
    {
        [Key]
        public int id { get; set; }
        public string profile { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string explanation { get; set; }
        public string contact { get; set; }


    }
}