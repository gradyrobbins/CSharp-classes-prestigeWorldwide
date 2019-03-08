using System;
using System.Collections.Generic;


namespace classesExercises
{
    public class Employee {
        public string firstName { get; set;}
        public string lastName { get; set; }
        public string title { get; set ;}
        public DateTime startDate { get; set; }

        public string FullName
        {
            get
            {
                return string.Format($"{firstName} {lastName}");
            }
        }


    };



// Create a custom type for Company. A company has the following properties.
    // Company name (string)
    // Date founded (DateTime)
    // Employees (List<Employee>)
    public class Company
{
    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> Employees {get; set;}

    // Create a constructor method that accepts two arguments:
    //     1. The name of the company
    //     2. The date it was created
    // The constructor will set the value of the public properties.  A constructor is special method in a class that is called when a new instance of the class is created. The role of a constructor is to make sure the new object is setup and ready for use immediately after it is created.

    public Company(string name, DateTime dateTime) {
        Name = name;
        CreatedOn = dateTime;
        Employees = new List<Employee>();
    }

    /*
        The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
    */
    public void ListEmployees()
    {
        foreach(Employee employee in Employees) {
                Console.WriteLine($"{employee.firstName} {employee.lastName} works for {Name} as{employee.title} since {employee.startDate.ToString("MM/dd/yyyy")}.");

        }
    }

}

class Program
{
    // In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.
        static void Main(string[] args)

    {
        // Create an instance of a company. Name it whatever you like.
        Company prestigeWorldwide = new Company("prestige worldwide", DateTime.Now);


        // Create three employees

         Employee zac = new Employee()
            {
                firstName = "Zac",
                lastName = "Crawford",
                title = "Chief Executive",
                startDate = DateTime.Now
            };
         Employee grady = new Employee()
            {
                firstName = "Grady",
                lastName = "Robbins",
                title = "Parliamentarian",
                startDate = DateTime.Now
            };
         Employee selaamawit = new Employee()
            {
                firstName = "Selaam",
                lastName = "-awit",
                title = "Engineering Lead",
                startDate = DateTime.Now
            };

        //write out the employees' names
        // Console.WriteLine($"{zac.FullName} \nworks for {prestigeWorldwide.Name} \ntitle:  {zac.title} \nsince {zac.startDate}\n\n");
        // Console.WriteLine($"{grady.FullName} \nworks for {prestigeWorldwide.Name} \ntitle:  {grady.title} \nsince \"****\"\n\n");
        // Console.WriteLine($"{selaamawit.FullName} \nworks for {prestigeWorldwide.Name} \ntitle:  {selaamawit.title} \nsince \"****\"\n\n");


        // Assign the employees to the company
        prestigeWorldwide.Employees.Add(zac);
        prestigeWorldwide.Employees.Add(grady);
        prestigeWorldwide.Employees.Add(selaamawit);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

    prestigeWorldwide.ListEmployees();

    }
}
}
