using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public static void Main(string[] args)
        {
            List<Employee> EmpList = new List<Employee>() {
            new Employee
            {
                Employee_Id = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager    ",DOB = new DateTime(1984, 11, 16, 0, 0, 0),DOJ = new DateTime(2011, 06, 8, 0, 0, 0), City = "Mumbai"
            },
            new Employee
            {
                Employee_Id = 1002, FirstName = "Asdin  ", LastName = "Dhalla  ", Title = "Asst.Manager", DOB = new DateTime(1984, 08, 20, 0, 0, 0), DOJ = new DateTime(2012, 07, 7, 0, 0, 0),
                City = "Mumbai"
            },
            new Employee
            {
                Employee_Id = 1003, FirstName = "Madhavi", LastName = "Oza    ", Title = "Consultant", DOB = new DateTime(1987, 11, 14, 0, 0, 0), DOJ = new DateTime(2015, 04, 12, 0, 0, 0), City = "pune"
            },
            new Employee
            {
                Employee_Id = 1004, FirstName = "Saba  ", LastName = "Shaikh ", Title = "   SE    ", DOB = new DateTime(1990, 06, 3, 0, 0, 0), DOJ = new DateTime(2016, 02, 2, 0, 0, 0), City = "pune"
            },
            new Employee
            {
                Employee_Id = 1005, FirstName = "Nazia ", LastName = "Shaikh ", Title = "  SE    ", DOB = new DateTime(1991, 03,8, 0, 0, 0), DOJ = new DateTime(2016, 02, 2, 0, 0, 0), City = "Mumbai"
            },
            new Employee
            {
                Employee_Id = 1006, FirstName = "Amit  ", LastName = "Pathak ", Title = "Consultant", DOB = new DateTime(1989, 11, 7, 0, 0, 0), DOJ = new DateTime(2014, 08, 8, 0, 0, 0), City = "Chennai"
            },
            new Employee
            {
                Employee_Id = 1007, FirstName = "Vijay ", LastName = "Natrajan ", Title = "Consultant", DOB = new DateTime(1989, 12, 2, 0, 0, 0), DOJ = new DateTime(2015, 06, 1, 0, 0, 0), City = "Mumbai"
            },
            new Employee
            {
                Employee_Id = 1008, FirstName = "Rahul ", LastName = "Dubey  ", Title = "Associate", DOB =new DateTime(1993, 11, 11, 0, 0, 0), DOJ = new DateTime(2014, 11, 6, 0, 0, 0), City = "Chennai"
            },
            new Employee
            {
                Employee_Id = 1009, FirstName = "Suresh ", LastName = "Misthry", Title = "Associate", DOB = new DateTime(1992, 12, 8, 0, 0, 0), DOJ = new DateTime(2014, 12, 3, 0, 0, 0), City = "Chennai"
            },
            new Employee
            {
                Employee_Id= 1010, FirstName = "Sumit ", LastName = "Shah   ", Title = "Manager", DOB = new DateTime(1991, 04, 12, 0, 0, 0),DOJ = new DateTime(2016, 01, 2, 0, 0, 0), City = "Pune"
            }




         };
            IEnumerable<Employee> EmployeeQuery =
                    from Employee in EmpList
                    where Employee.Employee_Id > 1000
                    select Employee;

           
            foreach (Employee e in EmployeeQuery)
            {

                // Call the to string method
                Console.WriteLine("{0},   {1},    {2},   {3},   {4},   {5},   {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);
           
            
            }
            Console.WriteLine();

            IEnumerable<Employee> EmployeeQuery1 =
                   from Employee in EmpList
                   where Employee.City != "Mumbai"
                   select Employee;
            Console.WriteLine("-------employees who are not in Mumbai---------");

            foreach (Employee e in EmployeeQuery1)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);


            }
            Console.WriteLine();

            IEnumerable<Employee> EmployeeQuery2 =
                   from Employee in EmpList
                   where Employee.Title == "Asst.Manager"
                   select Employee;
            Console.WriteLine("------details of Ass.Manager---------");

            foreach (Employee e in EmployeeQuery2)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);


            }
            Console.WriteLine();

            IEnumerable<Employee> EmployeeQuery3 =
                  from Employee in EmpList
                  where Employee.LastName[0] == 'S'
                  select Employee;
            Console.WriteLine("------Whose lastame starts with s---------");

            foreach (Employee e in EmployeeQuery3)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);


            }
            Console.WriteLine();

            IEnumerable<Employee> EmployeeQuery4 =
                  from Employee in EmpList
                  where Employee.DOJ < new DateTime(2015, 01,  01, 12, 00, 00)


                select Employee;
            Console.WriteLine("------- employee who have joined before 01-01-2015--------");

            foreach (Employee e in EmployeeQuery4)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);


            }
            Console.WriteLine();

            IEnumerable<Employee> EmployeeQuery5 =
                  from Employee in EmpList
                  where Employee.DOB > new DateTime(1990, 01, 01, 12, 00, 00)


                  select Employee;
            Console.WriteLine("------- employee who have born after 01-01-1990--------");

            foreach (Employee e in EmployeeQuery5)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);


            }
            Console.WriteLine();

            IEnumerable<Employee> EmployeeQuery6 =
                   from Employee in EmpList
                   where Employee.Title == "Associate" || Employee.Title=="Consultant"
                   select Employee;
            Console.WriteLine("------details of Associate and Consultant---------");

            foreach (Employee e in EmployeeQuery6)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);



            }
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("---------- employees count ----------");
            Console.WriteLine("total no. of employees: {0}",  EmpList.Count);
            Console.WriteLine();

            int EmployeeQuery7 = (from Employee in EmpList
                                  where Employee.City == "Chennai"
                                  select Employee).Count();

            Console.WriteLine();
            Console.WriteLine("no. of employee in Chennai: {0}", EmployeeQuery7);
            Console.WriteLine();

            int EmployeeQuery8 = EmpList.Max(x => x.Employee_Id);           
                Console.WriteLine("------Highest Employee in Employee database------");
            Console.WriteLine("highest employee id :{0}", EmployeeQuery8);
            Console.WriteLine();

            IEnumerable<Employee> EmployeeQuery9=
      from Employee in EmpList
      where Employee.DOJ > new DateTime(2015, 01, 01, 12, 00, 00)


      select Employee;
            Console.WriteLine("------- employee who have joined before 01-01-2015--------");
            Console.WriteLine();
            foreach (Employee e in EmployeeQuery9)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);


            }
            IEnumerable<Employee> EmployeeQuery10 =
                  from Employee in EmpList
                  where Employee.Title != "Associate"
                  select Employee;
            Console.WriteLine("------details of non associate employees---------");
            Console.WriteLine();

            foreach (Employee e in EmployeeQuery10)
            {

                // Call the to string method
                Console.WriteLine("{0},  {1},  {2},  {3},  {4},  {5},  {6}", e.Employee_Id, e.FirstName, e.LastName, e.Title, e.DOB, e.DOJ, e.City);


            }

            var EmployeeQuery11 = from Employee in EmpList
                                  group Employee by new
                                  {
                                      Employee.City,
                                  } into Employees
                                  select new
                                  {
                                      City = Employees.Key.City,
                                      count_City = Employees.OrderBy(o => o.City)
                                  };
            foreach(var i in EmployeeQuery11)
            {
                Console.WriteLine($"City: {i.City} number of employees = {i.count_City.Count()}");
                Console.WriteLine();



                var EmployeeQuery12 = from Employee in EmpList
                                      group Employee by new
                                      {
                                          Employee.City,
                                          Employee.Title,
                                      } into Employee1
                                      select new
                                      {
                                          City = Employee1.Key.City,
                                          Title = Employee1.Key.Title,
                                          count_City = Employee1.OrderBy(x => x.Title),
                                          count_Title = Employee1.OrderBy(x => x.Title)
                                      };
                Console.WriteLine("-----------Number of employees based on city and title-----------");
                Console.WriteLine();


                foreach(var v in EmployeeQuery12)
                {
                    Console.WriteLine($"City: {v.City}," +
                                      $"Title:{v.Title} " +
                                      $"Number of Employees ={v.count_City.Count()}");
                    Console.WriteLine();
                    
                }

            }

            var EmployeeQuery13 = EmpList.Select(en => en.DOB);

            Console.WriteLine();
            Console.WriteLine("-----------youngest Employee------------");
            Console.WriteLine();
            Console.WriteLine("youngest employee:   {0}", EmployeeQuery13.Max());
            

            Console.ReadLine();

        }

    }
}

