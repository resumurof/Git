using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Where_Aggregate
            //Code for Using Where Clause.
            string str = "Santhosh";
            string str2 = str.ChangeFirstLetterCase();
            Console.WriteLine(str2);

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 33, 53, 87, 89 };
            IEnumerable<int> elements = Enumerable.Where(numbers, X => X % 2 == 0);
            foreach (var ele in elements)
            {
                Console.WriteLine(ele);
            }

            //Code for using Aggregate functions.
            int number = numbers.Where(X => X % 2 == 0).Count();
            Console.WriteLine(number);
            string[] countries = { "India", "USA", "UK" };
            string[] countries = { "India", "US", "UK", "Canada", "Australia" };
            int[] Numbers = { 2, 3, 4, 5 };
            Console.WriteLine(Numbers.Aggregate((a, b) => a + ',' + b));

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 33, 53, 87, 89 };

            IEnumerable<int> nums = numbers.Where();
            //  Func<int, int, bool> predicate = (a, b) => a % 2 == 0;
            IEnumerable<int> allElements = numbers.Select((a, b) => new { Number = a, Index = b }).Where(X => X.Number % 2 == 0).Select(X => X.Index);

            foreach (var ele in allElements)
            {
                Console.WriteLine(ele);
            }
            #endregion

            #region Select_SelectMany
            //Code for using Select Clause.
            IEnumerable<string> employeeList = Employee.GetAllEmployees().Select(X => X.FirstName);
            foreach (var emp in employeeList)
            {
                Console.WriteLine(emp);
            }

            //To be discussed with john 
            /*This part is not working properly
            var subjectList = Student.GetAllStudents().SelectMany(X => X.Subjects, (Students, subj) => new
            {
                StudentName = Students.Name,
                Subject = subj
            });   */

            foreach (var subject in subjectList)
            {
                Console.WriteLine(subject.StudentName + "-" + subject.Subject);
            }

            SQL like Command
            IEnumerable<string> allSubjects = from Student in Student.GetAllStudetns()
                                              from subject in Student.Subjects
                                              select subject;

            String[] str =
                {
                 "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "0123456789"
                 };

            //Code for using SelectMany Clause.
            IEnumerable<char> charvar = str.SelectMany(X => X);

            foreach (var element in charvar)
            {
                Console.WriteLine(element);
            }

            IEnumerable<List<string>> result = Student.GetAllStudetns().Select(X => X.Subjects);

            foreach (var elements in result)
            {
                foreach (var element in elements)
                {
                    Console.WriteLine(element);
                }
            }

            IEnumerable<string> result = Student.GetAllStudetns().SelectMany(X => X.Subjects);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
            #endregion

            #region Ordering_Operators
            //Code for Ordering Operators

            IOrderedEnumerable<Student> studentList = Student.GetAllStudents().OrderBy(X => X.Name);

            foreach (var listofstudents in studentList)
            {
                Console.WriteLine(listofstudents.Name);
            }

            IOrderedEnumerable<Student> studentList = Student.GetAllStudents().OrderByDescending(X => X.Name);

            foreach (var listofstudents in studentList)
            {
                Console.WriteLine(listofstudents.Name);
            }

            //Code for Thenby
            IOrderedEnumerable<Student> studentList = Student.GetAllStudents().OrderBy(X => X.TotalMarks).ThenBy(Y => Y.Name).ThenBy(Z => Z.StudentID);

            foreach (var listofstudents in studentList)
            {
                Console.WriteLine(listofstudents.TotalMarks + "\t" + listofstudents.Name + "\t" + listofstudents.StudentID);
            }

            //Code for ThenbyDescending
            IOrderedEnumerable<Student> studentList = Student.GetAllStudents().OrderBy(X => X.TotalMarks).ThenByDescending(Z => Z.StudentID);

            foreach (var listofstudents in studentList)
            {
                Console.WriteLine(listofstudents.TotalMarks + "\t" + listofstudents.Name + "\t" + listofstudents.StudentID);
            }

            //Code for Reverse
            List<Student> studentlist = Student.GetAllStudents();

            Console.WriteLine("Student Info before Reverse");
            foreach (var listofstudents in studentlist)
            {
                Console.WriteLine(listofstudents.Name + "\t" + listofstudents.TotalMarks);
            }

            Console.WriteLine("                                 ");
            Console.WriteLine("Student Info After Reverse");
            IEnumerable<Student> resultlist = Student.GetAllStudents().Reverse<Student>();
            foreach (var listofstudents in resultlist)
            {
                Console.WriteLine(listofstudents.Name + "\t" + listofstudents.TotalMarks);
            }
            #endregion

            #region Partitioning_Operators
            //Code for partitioning operators 
            //Code for SKIP
            string[] str = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            IEnumerable<string> result = str.Skip(4);
            foreach (var elements in result)
            {
                Console.WriteLine(elements);
            }

            //Code for Take
            IEnumerable<string> result = str.Take(4);
            foreach (var elements in result)
            {
                Console.WriteLine(elements);
            }

            //Code for TakeWhile
            IEnumerable<string> result = str.TakeWhile(X => X.Length > 3);
            foreach (var elements in result)
            {
                Console.WriteLine(elements);
            }

            //Code for SkipWhile
            IEnumerable<string> result = str.SkipWhile(X => X.Length > 3);
            foreach (var elements in result)
            {
                Console.WriteLine(elements);
            }
            #endregion

            #region Deffered_Immediate
            //Code for Deferred Execution
            List<Student> stdList = new List<Student>
            {
               new Student {Name = "SAM", StudentID = 100, TotalMarks = 1000 },
               new Student {Name = "RAM", StudentID = 101, TotalMarks = 1001 },
               new Student {Name = "PAM", StudentID = 102, TotalMarks = 1002 }
            };

            stdList.Add(new Student { Name = "TIM", StudentID = 103, TotalMarks = 1003 });

            foreach (var students in stdList)
            {
                Console.WriteLine(students.Name + "\t" + students.StudentID + "\t" + students.TotalMarks);
            }

            //Code for Immediate Execution
            List<Student> stdList = new List<Student>
            {
               new Student {Name = "SAM", StudentID = 100, TotalMarks = 1000 },
               new Student {Name = "RAM", StudentID = 101, TotalMarks = 1001 },
               new Student {Name = "PAM", StudentID = 102, TotalMarks = 1002 }
            };
            int NoofStudents = stdList.Count();
            stdList.Add(new Student { Name = "TIM", StudentID = 103, TotalMarks = 1003 });

            Console.WriteLine("Immediate Execution Result, Total No. of Students {0}", NoofStudents);
            #endregion

            #region Conversion_Operators
            //Code for Conversion Operators
            int[] arr = { 66, 44, 1, 12, 99 };

            List<int> arrlist = arr.ToList();

            foreach (var elements in arrlist)
            {
                Console.WriteLine(elements);
            }

            //Code for Converting to Array
            List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            string[] arrayCountries = countries.ToArray();

            foreach (var country in arrayCountries)
            {
                Console.WriteLine(country);
            }

            //Code for Converting to Dictionary
            List<Student> stdList = new List<Student>
            {
               new Student {Name = "SAM", StudentID = 100, TotalMarks = 1000 },
               new Student {Name = "RAM", StudentID = 101, TotalMarks = 1001 },
               new Student {Name = "PAM", StudentID = 102, TotalMarks = 1002 }
            };

            Dictionary<int, string> dictionary = stdList.ToDictionary(X => X.StudentID, Y => Y.Name);

            foreach (var stdelements in dictionary)
            {
                Console.WriteLine(stdelements.Key + "\t" + stdelements.Value);
            }

            Dictionary<int, Student> dictionary = stdList.ToDictionary(X => X.StudentID, X => X);

            foreach (var stdelements in dictionary)
            {
                Console.WriteLine(stdelements.Key + "\t" + stdelements.Value.Name + "\t" + stdelements.Value.TotalMarks);
            }

            //Code for LookUp
            List<LookupEmployee> listEmployees = new List<LookupEmployee>
             {
                 new LookupEmployee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                 new LookupEmployee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                 new LookupEmployee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                 new LookupEmployee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                 new LookupEmployee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                 new LookupEmployee() { Name = "Pam", JobTitle = "Developer", City = "London" }
             };

            var lookupEmployees = listEmployees.ToLookup(X => X.JobTitle);

            Console.WriteLine("Employees based on Job Title");
            foreach (var employees in lookupEmployees)
            {
                Console.WriteLine(employees.Key);

                foreach (var emp in lookupEmployees[employees.Key])
                {

                    Console.WriteLine("\t" + emp.Name + "\t" + emp.City);
                }
            }
            #endregion


            #region CAST_OFTYPE
            //Code for Cast
            ArrayList arr = new ArrayList { 5, 1, 66, 12, 5656, 8, "2", "33" };
            IEnumerable<int> castearray = arr.Cast<int>();

            foreach (var element in castearray)
            {
                Console.WriteLine(element);
            }

            //Code for ofType
            IEnumerable<int> arrayoftype = arr.OfType<int>();

            foreach (var elementsofarray in arrayoftype)
            {
                Console.WriteLine(elementsofarray);
            }
            #endregion

            #region GROUP_BY
            //Code for GroupBy
            var employeeList = Employee.GetAllEmployees().GroupBy(X => X.Department);

            foreach (var employees in employeeList)
            {
                Console.WriteLine(employees.Key + " - " + employees.Count());

                foreach (var emplyee in employees)
                {
                    Console.WriteLine("\t" + emplyee.Name + "\t" + emplyee.Gender);
                }
            }

            //Code for Grouping with Multiple Keys
            var Employees = Employee.GetAllEmployees().GroupBy(X => new { X.Department, X.Gender })
                                       .OrderBy(G => G.Key.Department).ThenBy(H => H.Key.Gender)
                                       .Select(K => new { dept = K.Key.Department, gender = K.Key.Gender, Employees = K.OrderBy(X => X.Name) });

            foreach (var group in Employees)
            {
                foreach (var emp in group.Employees)
                {
                    Console.WriteLine(emp.Name + "\t" + emp.Salary);
                }
            }
            #endregion

            #region Element_Operators
            //Code for Element OPerators
            int[] arr = { 1, 2, 3, 87, 12, 45, 1, 6 };

            int element = arr.First();

            Console.WriteLine("First Element is {0}", element);

            element = arr.FirstOrDefault(X => X % 2 == 0);

            Console.WriteLine("First Even Element is {0}", element);

            int[] nullarr = { };

            int element = nullarr.First(); //Will throw an exception Since array is NULL

            Console.WriteLine("First Element of NULL array is {0}", element);

            int element = nullarr.FirstOrDefault();

            Console.WriteLine("First Element is {0}", element);

            int element = nullarr.ElementAt(1);

            Console.WriteLine("Element at index 1 is {0}", element);   //Will throw an exception Since array is NULL

            int element = nullarr.ElementAtOrDefault(1);

            Console.WriteLine("Element at index 1 is {0}", element);

            int element = arr.Last();

            Console.WriteLine("Last Element is {0}", element);

            int element = nullarr.Last(); //Will throw an exception Since array is NULL

            Console.WriteLine("Last Element of NULL array is {0}", element);    //Will throw an exception Since array is NULL

            int element = nullarr.LastOrDefault();

            Console.WriteLine("Last Element of NULL array is {0}", element);

            int[] singlearr = { 1, 2 };

            int element = singlearr.Single();

            Console.WriteLine("Single Element in array is {0}", element); // //Will throw an exception Since array Contains more than one element 

            int[] singlearr = { };

            int element = singlearr.SingleOrDefault();

            Console.WriteLine("Single Element in array is {0}", element);

            //Code for DefaultType
            int[] defaultarr = { };

            IEnumerable<int> element = defaultarr.DefaultIfEmpty();

            foreach (int i in element)
            {
                Console.WriteLine("Single Element in array is {0}", i);
            }

            IEnumerable<int> element = defaultarr.DefaultIfEmpty(10);

            foreach (int i in element)
            {
                Console.WriteLine("Single Element in array is {0}", i);
            }
            #endregion

            #region JOIN_OPERATIONS
            //Code for InnerJoin
            var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
                                                        e => e.DepartmentID,
                                                        K => K.ID,
                                                        (department, Employee) => new { Departname = department, EmployeeName = Employee });

            foreach (var i in result)
            {
                Console.WriteLine(i.EmployeeName.Name + "\t" + i.Departname.Name);
            }

            Code for Left Join
            var employees = Employee.GetAllEmployees().GroupJoin(Department.GetAllDepartments(),
                                            K => K.DepartmentID,
                                            D => D.ID,
                                            (empname, deptname) => new { empname, deptname })
                                            .SelectMany(K => K.deptname.DefaultIfEmpty(),
                                                        (Y, Z) => new
                                                        {
                                                            Empname = Y.empname.Name,
                                                            dptname = Z == null ? "NO DEPARTMENT" : Z.Name
                                                        });


            foreach (var i in employees)
            {
                Console.WriteLine(i.Empname + "\t" + i.dptname);
            }
            #endregion

            #region SET_OPERATIONS
            //Code for Set operations in LINQ

            string[] arr = { "canada", "CANADA", "US", "INDIA", "india" };

            IEnumerable<string> countries = arr.Distinct();
            foreach (string s in countries)
            {
                Console.WriteLine(s);
            }

            IEnumerable<string> countries = arr.Distinct(StringComparer.OrdinalIgnoreCase);
            foreach (string s in countries)
            {
                Console.WriteLine(s);
            }

            //Distinct for Complex types
            List<Employee> list = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Mary"}
            };

            //Approach 1
            var employees = list.Select(X => new { id = X.ID, name = X.Name }).Distinct();

            foreach (var emp in employees)
            {
                Console.WriteLine(emp.id + "\t" + emp.name);
            }

            //Approach 2
            IEnumerable<Employee> employees = list.Distinct();
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ID + "\t" + emp.Name);
            }
            #endregion

            #region UNION_INTERCEPT_EXCEPT
            //Code for Union
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 3, 6, 7, 8 };

            IEnumerable<int> result = arr1.Union(arr2);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            //Code for INTERCEPT
            IEnumerable<int> result = arr1.Intersect(arr2);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            //Code for EXCEPT
            IEnumerable<int> result = arr1.Except(arr2);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region GenerateOperations
            //Code for Enumerable
            IEnumerable<int> numbers = Enumerable.Range(1, 20).Where(X => X % 2 == 0);

            foreach (var ele in numbers)
            {
                Console.WriteLine(ele);
            }

            IEnumerable<string> elements = Enumerable.Repeat("SANTHOSH", 8);

            foreach (string str in elements)
            {
                Console.WriteLine(str);
            }
            #endregion

            #region Concat
            //Code for Concat
            string str = "hello";
            string str2 = "santhosh";
            string result = string.Concat(str, str2);
            Console.WriteLine(result);

            IEnumerable<int> result = arr1.Concat(arr2); //Concat will not remove duplicates unlike UNION
            foreach (var ele in result)
            {
                Console.WriteLine(ele);
            }
            #endregion

            #region SequenceOperator
            //Code for SequenceEqual
            string[] countries1 = { "USA", "India", "UK" };
            string[] countries2 = { "USA", "India", "UK" };
            Console.WriteLine(countries1.SequenceEqual(countries2));

            string[] countries3 = { "USA", "India", "UK" };
            string[] countries4 = { "UK", "USA", "India" };
            Console.WriteLine(countries3.OrderBy(X => X).SequenceEqual(countries4.OrderBy(Y => Y)));

            //SequenceEqual code for Reference types
            List<Employee> list1 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"},
            };

            List<Employee> list2 = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Mike"},
                new Employee { ID = 102, Name = "Susy"},
            };

            bool result = list1.SequenceEqual(list2);

            Console.WriteLine("Result of Comparing two sequenvce {0}", result);
            #endregion

            #region Quantifiers
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Result of using Any (Quantifiers) {0}", numbers.All(X => X == 2));
            Console.WriteLine("Result of using Any (Quantifiers) {0}", numbers.Any(X => X % 2 == 0));
            #endregion
        }
    }
}
