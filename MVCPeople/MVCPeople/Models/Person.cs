using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPeople.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required."), Range(0, 150)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Postal code is required."), Range(6, 7)]
        public int PostalCode { get; set; }
    }
}