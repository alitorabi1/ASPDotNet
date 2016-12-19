using LinqCarsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinqCarsMVC.Controllers
{
    public class CarController : Controller
    {
        private OperationDataContext context = new OperationDataContext();

        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CarsWithoutOwner()
        {
            ViewBag.Heading = "Cars Without Owner";
            var queryCarsWithoutOwner = from c in context.Cars where c.ownerId == null select c;

            return View("Cars", queryCarsWithoutOwner.ToList());
        }

        public ActionResult OwnersWithMultipleCars()
        {
            IList<OwnerDetails> ownerList = new List<OwnerDetails>();

            var queryOwnersWithMultipleCars = from owner in context.Owners
                                              join car in context.Cars on owner.Id equals car.ownerId
                                              group owner by
                                              new { owner.Id, owner.FirstName, owner.LastName, owner.DriverLicense, owner.Birthdate }
                                                  into s
                                                  where s.Count() > 1
                                                  select new
                                                  {
                                                      Id = s.Key.Id,
                                                      FirstName = s.Key.FirstName,
                                                      LastName = s.Key.LastName,
                                                      DriverLicense = s.Key.DriverLicense,
                                                      Birthate = s.Key.Birthdate,
                                                      CarsCount = s.Count()
                                                  };

            foreach (var item in queryOwnersWithMultipleCars)
            {
                ownerList.Add(new OwnerDetails()
                {
                    Owner = new Owner()
                    {
                        Id = item.Id,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        DriverLicense = item.DriverLicense,
                        Birthdate = item.Birthate
                    },
                    CarsCount = item.CarsCount
                });
            }

            return View("RichOwners", ownerList);
        }
        public ActionResult CarsYopRange(string yopMinString, string yopMaxString)
        {
            ViewBag.YopRange = true;
            ViewBag.Heading = "Cars produced in a certain period";


            int yopMin;
            int yopMax;

            if (!Int32.TryParse(yopMinString, out yopMin))
            {
                yopMin = 0;
            }
            if (!Int32.TryParse(yopMaxString, out yopMax))
            {
                yopMax = (from car in context.Cars select car.Yop).Max();
            }
            var queryCarsYopRange = from c in context.Cars where c.Yop >= yopMin && c.Yop <= yopMax select c;

            return View("Cars", queryCarsYopRange.ToList());
        }
        public ActionResult OwnersAgeRange(string AgeMinString, string AgeMaxString)
        {
            int ageMin;
            int ageMax;
            IList<OwnerDetails> owners = new List<OwnerDetails>();

            if (!Int32.TryParse(AgeMinString, out ageMin))
            {
                ageMin = 0;

            }
            if (!Int32.TryParse(AgeMaxString, out ageMax))
            {
                ageMax = 150;

            }
            var queryOwnersAgeRange = from owner in context.Owners
                                      //get the difference in years since the birthdate
                                      let years = DateTime.Now.Year - owner.Birthdate.Year
                                      //get the date of the birthday this year
                                      let birthdayThisYear = owner.Birthdate.AddYears(years)
                                      let age = birthdayThisYear > DateTime.Now ? years - 1 : years
                                      where age >= ageMin && age <= ageMax
                                      select new
                                      {
                                          OwnerDetails = owner,
                                          //if the birthday hasn't passed yet this year we need years - 1
                                          Age = age
                                      };

            foreach (var item in queryOwnersAgeRange)
            {
                owners.Add(new OwnerDetails()
                {
                    Owner = item.OwnerDetails,
                    Age = item.Age

                });
            }


            return View("OwnersByAge", owners);
        }


        public ActionResult OwnersSorted(string SortByString)
        {
            ViewBag.SortedBy = SortByString;
            var SortByList = new List<string> { "Birthdate", "Driver License", "Last Name" };
            ViewBag.SortByString = new SelectList(SortByList);

            var queryOwners = from owner in context.Owners
                              select owner;

            if (!String.IsNullOrEmpty(SortByString))
            {
                switch (SortByString)
                {
                    case "Birthdate":
                        queryOwners = queryOwners.OrderBy(q => q.Birthdate);
                        break;
                    case "Driver License":
                        queryOwners = queryOwners.OrderBy(q => q.DriverLicense);
                        break;
                    case "Last Name":
                        queryOwners = queryOwners.OrderBy(q => q.LastName);
                        break;
                    default:
                        break;
                }

               // queryOwners = queryOwners.OrderBy(s => s.GetType().GetProperty(SortByString).GetValue(s, null));

            }
           


            return View("Owners", queryOwners.ToList());
        }


        public ActionResult CarsContains(string SearchString)
        {
            IList<CarDetails> carsList = new List<CarDetails>();
            var queryOwnersAndCars = from car in context.Cars
                                     join owner in context.Owners on car.ownerId equals owner.Id
                                     select new
                                     {
                                         CarDetails = car,
                                         OwnerDetails = owner
                                     };
            if (!String.IsNullOrEmpty(SearchString))
            {
                queryOwnersAndCars = queryOwnersAndCars.Where(s => (s.CarDetails.Make.Contains(SearchString)
                || s.CarDetails.Model.Contains(SearchString)));
            }

            foreach (var item in queryOwnersAndCars)
            {
                carsList.Add(new CarDetails()
                {
                    Car = item.CarDetails,
                    Owner = item.OwnerDetails
                });

            }

            return View("CarsDetails", carsList);
        }
    }
}