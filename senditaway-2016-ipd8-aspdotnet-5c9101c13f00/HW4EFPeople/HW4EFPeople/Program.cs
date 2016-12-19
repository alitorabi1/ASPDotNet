using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EFPeople
{
    class Program
    {

        static Context ctx;

        static void Main(string[] args)
        {
            using (ctx = new Context())
            {
                while (true)
                {
                    string choice = AskForInput();
                    try
                    {

                        switch (choice)
                        {
                            case "1":
                                Console.Write("Enter person name:");
                                string name = Console.ReadLine();
                                Console.Write("Enter person age:");
                                int age = Convert.ToInt32(Console.ReadLine());
                                Person personToInsert = new Person { Name = name, Age = age };
                                ctx.Persons.Add(personToInsert);
                                ctx.SaveChanges();
                                Console.WriteLine("{0} of age {1} was added to the database", name, age);
                                break;
                            case "2":

                                foreach (var person in ctx.Persons)
                                {
                                    Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
                                }
                                break;


                            case "3":
                                Console.Write("Enter person id to delete:");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Person personToDelete = ctx.Persons.Find(id);
                                ctx.Persons.Remove(personToDelete);
                                ctx.SaveChanges();
                                break;
                            case "0":
                                Console.WriteLine("Are you sure you want to exit application? Enter Y/N");
                                string answer = Console.ReadLine();
                                if (answer.ToLower() == "y") {
                                        Environment.Exit(0);
                                }
                                break;

                        }
                    }

                    catch (Exception)
                    {

                        Console.Write("Database Error");
                        Console.ReadKey();
                        throw new Exception();
                    }
                }
            }
        }

        private static string AskForInput()
        {
            Console.WriteLine("Please Choose an Option: \n -------------------------------------");
            Console.WriteLine("1. Add Person \n 2.List people \n 3. Delete Person by ID \n 0. Exit");

            string choice = Console.ReadLine();
            return choice;
        }
    }
}
