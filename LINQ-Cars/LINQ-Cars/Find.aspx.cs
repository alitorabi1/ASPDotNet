using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_Cars
{
    public partial class Find : System.Web.UI.Page
    {
        public CarsDataContext carsDb = new CarsDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btCarsNoOwner_Click(object sender, EventArgs e)
        {
            gvResult.DataSource = from Car in carsDb.Cars
                                  where Car.OwnerId == null
                                  select Car;
            gvResult.DataBind();
        }

        protected void btOwnersMoreThanOneCar_Click(object sender, EventArgs e)
        {
            //            var min
            //gvResult.DataSource = from Owner in carsDb.Owners
            //                      where Owner.Id.Contains
            //                      (
            //                          carsDb.Cars.GroupBy(c => c.OwnerId).Where(grp => grp.Count() > 1).Select(grp => grp.Key)
            //                      )
            //                      select Owner.FirstName + " " + Owner.LastName;

            //gvResult.DataBind();
//            select concat(Owner.FirstName, ' ', owner.LastName) from Owner
//where Owner.Id in
//(select ownerId from Car
//group by OwnerId
//having count(car.OwnerId) > 1)

        }

        protected void btFind_Click(object sender, EventArgs e)
        {
            var itemSearch = tbFind.Text;
            gvResult.DataSource = from Car in carsDb.Cars
                                  where Car.Make.Contains(itemSearch) || Car.Model.Contains(itemSearch)
                                  select Car;
            gvResult.DataBind();
        }

        protected void btCarsMadeBetweenMinAndMax_Click(object sender, EventArgs e)
        {
            var minYear = (from Car in carsDb.Cars select Car.Yop).Min();
            var maxYear = (from Car in carsDb.Cars select Car.Yop).Max();
            gvResult.DataSource = from Car in carsDb.Cars
                                  where Car.Yop > minYear && Car.Yop < maxYear
                                  select Car;
            gvResult.DataBind();
        }

        protected void btOwnersAgeBetweenMinAndMax_Click(object sender, EventArgs e)
        {
            var minAge = (from Owner in carsDb.Owners select Owner.BirthDate).Max();
            var maxAge = (from Owner in carsDb.Owners select Owner.BirthDate).Min();
            gvResult.DataSource = from Owner in carsDb.Owners
                                  where Owner.BirthDate < minAge && Owner.BirthDate > maxAge
                                  select Owner;
            gvResult.DataBind();
        }
    }
}