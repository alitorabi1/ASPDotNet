using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Quiz2Airport.Models
{
    public class Travel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 150)]
        public int Age { get; set; }

        [RegularExpression(@"^[A-Z][A-Z][0-9]{6}$", ErrorMessage = "Passport must be in Canadian passport format")]
        public string PassportNo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateDeparture { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateArrival { get; set; }

        [Required]
        [StringLength(3)]
        [RegularExpression(@"^[A-Z][A-Z][A-Z]$", ErrorMessage = "From Airport must be 3 uppercase characters")]
        public string FromAirport { get; set; }

        [Required]
        [StringLength(3)]
        [RegularExpression(@"^[A-Z][A-Z][A-Z]$", ErrorMessage = "To Airport must be 3 uppercase characters")]
        public string ToAirport { get; set; }

        public ComfortClass Comfort { get; set; }
    }

    public enum ComfortClass { Economy, EconomyPlus, Premium, Business };

}