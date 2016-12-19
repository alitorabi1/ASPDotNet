using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqCarsMVC.Models
{
    public class CarDetails
    {
        public Car Car { get; set; }
        public Owner Owner { get; set; }
    }
}