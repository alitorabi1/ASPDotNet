using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCSayHello.Models
{
    public class PersonModel
    {
        [Required (ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required."), Range(0, 150)]
        public int Age { get; set; }
    }
}