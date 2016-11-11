using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_First
{
    class LinqToSQLCRUD
    {
        static void Main(string[] args)
        {
            string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["CarsConnectionString"].ToString();

            LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);

            //Create new Car
            Car newCar = new Car();
            newCar.Make = "Michael";
            newCar.Model = "yourname";
            newCar.Plates = "3434343";
            newCar.Yop = 2014;
            newCar.OwnerId = 3 ;

            //Add new Employee to database
            db.Cars.InsertOnSubmit(newCar);

            //Save changes to Database.
            db.SubmitChanges();

            //Get new Inserted Employee            
            Car insertedCar = db.Cars.FirstOrDefault(e => e.Make.Equals("Michael"));

            Console.WriteLine("Employee Id = {0} , Name = {1}, Email = {2}, ContactNo = {3}, Address = {4}",
                              insertedCar.Id, insertedCar.Make, insertedCar.Model,
                              insertedCar.Plates, insertedCar.Yop, insertedCar.OwnerId);

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}