using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    //There are many Employee Structure which is specific for a particular structure called from Main, Based on the code calling from Main these structure need to be Enabled

    #region LookupEmployee_Class
    public class LookupEmployee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
    }
    #endregion

    class Employee
    {

        #region Employee_Structure1
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 101,
                    FirstName = "Tom",
                    LastName = "Daely",
                    Gender = "Male",
                    AnnualSalary = 60000
                },
                new Employee
                {
                    EmployeeID = 102,
                    FirstName = "Mike",
                    LastName = "Mist",
                    Gender = "Male",
                    AnnualSalary = 72000
                },
                new Employee
                {
                    EmployeeID = 103,
                    FirstName = "Mary",
                    LastName = "Lambeth",
                    Gender = "Female",
                    AnnualSalary = 48000
                },
                new Employee
                {
                    EmployeeID = 104,
                    FirstName = "Pam",
                    LastName = "Penny",
                    Gender = "Female",
                    AnnualSalary = 84000
                },
            };

            return listEmployees;
        }
    }
    #endregion

    #region Employee_Structure2
    public string Name { get; set; }
    public string Gender { get; set; }
    public List<string> Subjects { get; set; }

    public static List<Student> GetAllStudetns()
    {
        List<Student> listStudents = new List<Student>
        {
            new Student
            {
                Name = "Tom",
                Gender = "Male",
                Subjects = new List<string> { "ASP.NET", "C#" }
            },
            new Student
            {
                Name = "Mike",
                Gender = "Male",
                Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
            },
            new Student
            {
                Name = "Pam",
                Gender = "Female",
                Subjects = new List<string> { "WCF", "SQL Server", "C#" }
            },
            new Student
            {
                Name = "Mary",
                Gender = "Female",
                Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
            },
        };

        return listStudents;
    }
    #endregion

    #region Employee_Structure3
    public int StudentID { get; set; }
    public string Name { get; set; }
    public int TotalMarks { get; set; }

    public static List<Student> GetAllStudents()
    {
        List<Student> listStudents = new List<Student>
    {
        new Student
        {
            StudentID= 101,
            Name = "Tom",
            TotalMarks = 800
        },
        new Student
        {
            StudentID= 102,
            Name = "Mary",
            TotalMarks = 900
        },
        new Student
        {
            StudentID= 103,
            Name = "Valarie",
            TotalMarks = 800
        },
        new Student
        {
            StudentID= 104,
            Name = "John",
            TotalMarks = 800
        },
    };

        return listStudents;
    }
    #endregion


    #region Employee_Structure4
    public string Name { get; set; }
    public string Gender { get; set; }
    public List<string> Subjects { get; set; }

    public static List<Employee> GetAllStudetns()
    {
        List<Employee> listStudents = new List<Employee>
    {
        new Employee
        {
            Name = "Tom",
            Gender = "Male",
            Subjects = new List<string> { "ASP.NET", "C#" }
        },
        new Employee
        {
            Name = "Mike",
            Gender = "Male",
            Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
        },
        new Employee
        {
            Name = "Pam",
            Gender = "Female",
            Subjects = new List<string> { "WCF", "SQL Server", "C#" }
        },
        new Employee
        {
            Name = "Mary",
            Gender = "Female",
            Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
        },
    };

        return listStudents;
    }
    #endregion

    #region Employee_Structure5
    public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public int DepartmentID { get; set; }

    public static List<Employee> GetAllEmployees()
    {
            return new List<Employee>()
            {
                //new Employee { ID = 1, Name = "Mark", Gender = "Male",
                //                             Department = "IT", Salary = 45000 },
                //new Employee { ID = 2, Name = "Steve", Gender = "Male",
                //                             Department = "HR", Salary = 55000 },
                //new Employee { ID = 3, Name = "Ben", Gender = "Male",
                //                             Department = "IT", Salary = 65000 },
                //new Employee { ID = 4, Name = "Philip", Gender = "Male",
                //                             Department = "IT", Salary = 55000 },
                //new Employee { ID = 5, Name = "Mary", Gender = "Female",
                //                             Department = "HR", Salary = 48000 },
                //new Employee { ID = 6, Name = "Valarie", Gender = "Female",
                //                             Department = "HR", Salary = 70000 },
                //new Employee { ID = 7, Name = "John", Gender = "Male",
                //                             Department = "IT", Salary = 64000 },
                //new Employee { ID = 8, Name = "Pam", Gender = "Female",
                //                             Department = "IT", Salary = 54000 },
                //new Employee { ID = 9, Name = "Stacey", Gender = "Female",
                //                             Department = "HR", Salary = 84000 },
                //new Employee { ID = 10, Name = "Andy", Gender = "Male" }

                new Employee { ID = 1, Name = "Mark", DepartmentID = 1 },
                new Employee { ID = 2, Name = "Steve", DepartmentID = 2 },
                new Employee { ID = 3, Name = "Ben", DepartmentID = 1 },
                new Employee { ID = 4, Name = "Philip", DepartmentID = 1 },
                new Employee { ID = 5, Name = "Mary", DepartmentID = 2 },
                new Employee { ID = 6, Name = "Valarie", DepartmentID = 2 },
                new Employee { ID = 7, Name = "John", DepartmentID = 1 },
                new Employee { ID = 8, Name = "Pam", DepartmentID = 1 },
                new Employee { ID = 9, Name = "Stacey", DepartmentID = 2 },
                new Employee { ID = 10, Name = "Andy"}
            }
        };
        public override bool Equals(object obj)
        {
            return (this.ID == ((Employee)obj).ID && this.Name == ((Employee)obj).Name);
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.Name.GetHashCode();
        }
    #endregion

    }
}

