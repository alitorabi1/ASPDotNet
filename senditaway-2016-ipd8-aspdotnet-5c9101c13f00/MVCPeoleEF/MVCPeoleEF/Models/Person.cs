using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCPeoleEF.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, MinimumLength=2)]
        [Required]
        public string  Name { get; set; }

        [Range(1,150)]
        public int Age { get; set; }

        [RegularExpression(@"^([A-Z][0-9]){3}$", ErrorMessage="Potal Code must be in format A0A0A0")]
        public string PostalCode { get; set; }

        public Gender Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [CustomDate(ErrorMessage="You cannot be born in future :) and unfortunately you cannot be more than 150 years old")]
        public DateTime BirthDate { get; set; }
    }

   public  enum Gender
    {
        NA, Male, Female
    }

    public class PeopleDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
    public class CustomDateAttribute : RangeAttribute
{
  public CustomDateAttribute()
    : base(typeof(DateTime), 
            DateTime.Now.AddYears(-150).ToShortDateString(),
            DateTime.Now.ToShortDateString()) 
  { } 
}
}