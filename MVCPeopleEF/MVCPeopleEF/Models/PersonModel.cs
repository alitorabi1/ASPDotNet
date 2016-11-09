using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPeopleEF.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required."), StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required."), Range(0, 150)]
        public int Age { get; set; }

        [RegularExpression(@"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]$")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Please select your gender.")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

    }

    public enum Gender { NA, M, F };

}