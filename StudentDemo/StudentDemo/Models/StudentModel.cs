using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentDemo.Models
{
    public class StudentModel
    {
        [Required (ErrorMessage = "Student name is required."), Range(2, 150)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Class name is required."), Range(2, 150)]
        public string Class { get; set; }
    }
}