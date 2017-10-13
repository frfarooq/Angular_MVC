using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Angular.Models
{
    public class Registeration
    {
       [Required]
        public int id { get; set; }

       [Required]
       [MinLength (3)]
       [MaxLength (11)]
        public string name{get; set;}

       [Required]
       [Phone]
        public string phone { get; set; }
    }
}