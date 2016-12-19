using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqCarsMVC.Models
{
    public class OwnerDetails
    {
        public Owner Owner { get; set; }
        public int Age { get; set; }
        public int CarsCount { get; set; }
    }
}