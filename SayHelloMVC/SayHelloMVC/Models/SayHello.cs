using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SayHelloMVC.Models
{
    public class SayHello
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,150)]
        public int Age { get; set; }
    }
}