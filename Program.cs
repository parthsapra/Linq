using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        public static int choice;
        public static readonly List<Incentive> incentives = new List<Incentive>()
        {
            new Incentive()
            {
                EmployeeReffId=1,
                IncentiveDate=new DateTime(2013,02,01),
                IncentiveAmount=5000
            },
            new Incentive()
            {
                EmployeeReffId=2,
                IncentiveDate=new DateTime(2013,02,01),
                IncentiveAmount=3000
            },
            new Incentive()
            {
                EmployeeReffId=3,
                IncentiveDate=new DateTime(2013,02,01),
                IncentiveAmount=4000
            },
            new Incentive()
            {
                EmployeeReffId=1,
                IncentiveDate=new DateTime(2013,01,01),
                IncentiveAmount=4500
            },
            new Incentive()
            {
                EmployeeReffId=2,
                IncentiveDate=new DateTime(2013,01,01),
                IncentiveAmount=3500
            }
        };
        public static readonly List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                 EmployeeId = 1,
                 FirstName = "John",
                 LastName = "Abharam",
                 Salary = 1000000,
                 JoiningDate = new DateTime(2013, 01, 01),
                 Department = "Banking"
            },
            new Employee()
            {
                 EmployeeId = 2,
                 FirstName = "Michael",
                 LastName = "Clarke",
                 Salary = 800000,
                 JoiningDate = new DateTime(2013, 01, 01),
                 Department = "Insurance"
            },
            new Employee()
                {
                    EmployeeId = 3,
                    FirstName = "Roy",
                    LastName = "thomas",
                    Salary = 700000,
                    JoiningDate = new DateTime(2013, 02, 01),
                    Department = "Banking"
                },
                 new Employee()
                {
                    EmployeeId = 4,
                    FirstName = "Tom",
                    LastName = "Jose",
                    Salary = 600000,
                    JoiningDate = new DateTime(2013, 02, 01),
                    Department = "Insurance"
                },
                 new Employee()
                {
                    EmployeeId = 5,
                    FirstName = "Jerry",
                    LastName = "Pinto",
                    Salary = 650000,
                    JoiningDate = new DateTime(2013, 02, 01),
                    Department = "Insurance"
                },
                 new Employee()
                {
                    EmployeeId = 6,
                    FirstName = "Phillip",
                    LastName = "Mathew ",
                    Salary = 750000,
                    JoiningDate = new DateTime(2013, 01, 01),
                    Department = "Services"
                },
                  new Employee()
                {
                    EmployeeId = 7,
                    FirstName = "TestName1",
                    LastName = "123",
                    Salary = 650000,
                    JoiningDate = new DateTime(2013, 01, 01),
                    Department = "Services"
                },
                   new Employee()
                {
                    EmployeeId = 8,
                    FirstName = "TestName2",
                    LastName = "Lname%",
                    Salary = 600000,
                    JoiningDate = new DateTime(2013, 02, 01),
                    Department = "Insurance"
                }
        };
        static void Main(string[] args)
        {
            bool loopForOption = true;
            while (loopForOption)
            {
                Console.WriteLine("1.Get all Employee Details");
                Console.WriteLine("2.Get first name and last name from employee table");
                Console.WriteLine("5.Get First_Name from employee table in upper case");
                Console.WriteLine("6.Get First_Name from employee table in lower case");
                Console.WriteLine("7.Get unique DEPARTMENT from employee table");
                Console.WriteLine("12.Get length of FIRST_NAME from employee table");
                Console.WriteLine("15.Get FIRST_NAME ,Joining year,Joining Month and Joining Date from employee table");
                Console.WriteLine("16.Get all employee details from the employee table order by First_Name Ascending");
                Console.WriteLine("17.Get all employee details from the employee table order by First_Name descending");
                Console.WriteLine("18.Get all employee details from the employee table order by First_Name Ascending and Salary descending");
                Console.WriteLine("19.Get employee details from employee table whose employee name is “John”");
                Console.WriteLine("20.Get employee details from employee table whose employee name are “John” and “Roy”");
                Console.WriteLine("21.Get employee details from employee table whose employee name are not “John” and “Roy”");
                Console.WriteLine("22.Get employee details from employee table whose first name starts with 'J'");
                Console.WriteLine("23.Get employee details from employee table whose first name contains 'o'");
                Console.WriteLine("24.Get employee details from employee table whose first name ends with 'n'");
                Console.WriteLine("25. Get employee details from employee table whose first name ends with 'n' and name contains 4 letters");
                Console.WriteLine("26.Get employee details from employee table whose first name starts with 'J' and name contains 4 letters");
                Console.WriteLine("27. Get employee details from employee table whose Salary greater than 600000");
                Console.WriteLine("28.  Get employee details from employee table whose Salary less than 800000");
                Console.WriteLine("29. Get employee details from employee table whose Salary between 500000 and 800000");
                Console.WriteLine("30. Get employee details from employee table whose name is 'John' and 'Michael' ");
                Console.WriteLine("31. Get employee details from employee table whose joining year is 2013 ");
                Console.WriteLine("32. Get employee details from employee table whose joining month is “January” ");
                Console.WriteLine("33. Get employee details from employee table who joined before January 31st 2013 ");
                Console.WriteLine("34. Get employee details from employee table who joined after January 31st ");
                Console.WriteLine("35.  Get Joining Date and Time from employee table ");
                Console.WriteLine("39. Get names of employees from employee table who has '%' in Last_Name");
                //Console.WriteLine("40.  Get Last Name from employee table after replacing special character with white space ");
                Console.WriteLine("49.  Select first_name, incentive amount from employee and incentives table for those employees who have incentives ");
                Console.WriteLine("50. Select first_name, incentive amount from employee and incentives table for those employees who have incentives and incentive amount greater than 3000 ");
                Console.WriteLine("51. Select first_name, incentive amount from employee and incentives table for all employed even if they didn't get incentives. ");
                Console.WriteLine("65. Exit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        getEmployeeDetails();
                        break;
                    case 2:
                        getFullNameofEmployee();
                        break;
                    case 3:
                        getFirstNameInUpperCase();
                        break;
                    case 6:
                        getFirstNameInLowerCase();
                        break;
                    case 7:
                        getUniqueDepartment();
                        break;
                    case 12:
                        getLengthofFirstName();
                        break;
                    case 15:
                        getFirstNameAndDateOfJoining();
                        break;
                    case 16:
                        getFirstNameAscending();
                        break;
                    case 17:
                        getFirstNameDescending();
                        break;
                    case 18:
                        getEmployeeDetailsFirstNameAscAndSalaryDes();
                        break;
                    case 19:
                        getEmployeeNameJohn();
                        break;
                    case 20:
                        getEmployeeNameJohnRoy();
                        break;
                    case 21:
                        getEmployeeNameNotJohnRoy();
                        break;
                    case 22:
                        getEmployeeNameStartWithJ();
                        break;
                    case 23:
                        getEmployeeNameContainsO();
                        break;
                    case 24:
                        getEmployeeNameEndsWithN();
                        break;
                    case 25:
                        getEmployeeNameEndsWithNContain4();
                        break;
                    case 26:
                        getEmployeeNameStartWithJContains4();
                        break;
                    case 27:
                        getEmployeeSalaryGreater();
                        break;
                    case 28:
                        getEmployeeSalaryLeser();
                        break;
                    case 29:
                        getEmployeeSalaryBetween();
                        break;
                    case 30:
                        getEmployeeNameJohnMichale();
                        break;
                    case 31:
                        getEmployeeByJoiningYear();
                        break;
                    case 32:
                        getEmployeeByJoiningMonth();
                        break;
                    case 33:
                        getEmployeeBeforeJoiningDate();
                        break;
                    case 34:
                        getEmployeeAfterJoiningDate();
                        break;
                    case 35:
                        getJoiningDate();
                        break;
                    case 39:
                        getLastName();
                        break;
                    //case 40:
                    //    getLastNameAfterReplaceChar();
                    //    break;
                    case 49:
                        getFirstNameIncentiveAmount();
                        break;
                    case 50:
                        getFirstNameIncentiveAmountGreater();
                        break;
                    //case 51:
                    //    getFirstNameIncentiveAmountIfNotIncentive();
                    //    break;
                    case 65:
                        break;
                    default:
                        break;
                }
            }
        }

              private static void getFirstNameIncentiveAmountGreater()
        {
            var empData = employees.Join(incentives, emp => emp.EmployeeId, inc => inc.EmployeeReffId, (emp, inc) => new { emp.FirstName, inc.IncentiveAmount }).Where(inc => inc.IncentiveAmount > 3000);
            foreach (var empInc in empData)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + empInc.FirstName);
                Console.WriteLine("Incentive Amount:" + empInc.IncentiveAmount);
            }
        }
        private static void getFirstNameIncentiveAmount()
        {
            var empData = employees.Join(incentives, emp => emp.EmployeeId, inc => inc.EmployeeReffId, (emp, inc) => new { emp.FirstName, inc.IncentiveAmount });
            foreach (var empInc in empData)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + empInc.FirstName);
                Console.WriteLine("Incentive Amount:" + empInc.IncentiveAmount);
            }
        }
        //private static void getLastNameAfterReplaceChar()
        //{
        //    var empDetail = employees.Where(name => name.LastName.Contains("%"));

        //    foreach (var employee in empDetail)
        //    {
        //        Console.WriteLine("FirstName:" + employee.FirstName);
        //        Console.WriteLine("LasrName:" + employee.LastName);
        //        Console.WriteLine("\n");
        //    }
        //}
        private static void getLastName()
        {
            var empDetail = employees.Where(name => name.LastName.Contains("%"));
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("\n");
            }
        }
        private static void getJoiningDate()
        {
            var joindate = from Employee in employees select new { Employee.JoiningDate };
            foreach (var dateofjoin in joindate)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Joining Date:" + dateofjoin.JoiningDate);
            }
        }
        private static void getEmployeeAfterJoiningDate()
        {
            DateTime newDate = new DateTime(2013, 01, 31);
            var empDetail = employees.Where(joindate => joindate.JoiningDate > newDate);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeBeforeJoiningDate()
        {
            DateTime newDate = new DateTime(2013, 01, 31);
            var empDetail = employees.Where(joindate => joindate.JoiningDate < newDate);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeByJoiningMonth()
        {
            var empDetail = employees.Where(month => month.JoiningDate.Month == 1);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeByJoiningYear()
        {
            var empDetail = employees.Where(year => year.JoiningDate.Year == 2013);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNameJohnMichale()
        {
            var empDetail = employees.Where(name => name.FirstName == "John" || name.FirstName == "Michale");
            foreach (var employee in empDetail)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
            }
        }
        private static void getEmployeeSalaryBetween()
        {
            var empDetail = employees.Where(salary => salary.Salary > 500000 && salary.Salary < 800000);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeSalaryLeser()
        {
            var empDetail = employees.Where(salary => salary.Salary < 800000);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeSalaryGreater()
        {
            var empDetail = employees.Where(salary => salary.Salary > 600000);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNameStartWithJContains4()
        {
            var empDetail = employees.Where(name => name.FirstName.StartsWith("J") && name.FirstName.Length == 4);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNameEndsWithNContain4()
        {
            var empDetail = employees.Where(name => name.FirstName.EndsWith("n") && name.FirstName.Length == 4);
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNameEndsWithN()
        {
            var empDetail = employees.Where(name => name.FirstName.EndsWith("n"));
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNameContainsO()
        {
            var empDetail = employees.Where(name => name.FirstName.Contains("o"));
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNameStartWithJ()
        {
            var empDetail = employees.Where(name => name.FirstName.StartsWith("J"));
            foreach (var employee in empDetail)
            {
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNameNotJohnRoy()
        {
            var empDetail = employees.Where(name => name.FirstName != "John" || name.FirstName != "Roy");
            foreach (var employee in empDetail)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
            }
        }
        private static void getEmployeeNameJohnRoy()
        {
            var empDetail = employees.Where(name => name.FirstName == "John" || name.FirstName == "Roy");
            foreach (var employee in empDetail)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
            }
        }
        public static void getEmployeeNameJohn()
        {
            var empDetail = employees.Where(name => name.FirstName == "John").FirstOrDefault();
            Console.WriteLine("\n");
            Console.WriteLine("FirstName:" + empDetail.FirstName);
            Console.WriteLine("LasrName:" + empDetail.LastName);
            Console.WriteLine("Salary:" + empDetail.Salary);
            Console.WriteLine("JoiningDate:" + empDetail.JoiningDate);
            Console.WriteLine("Department:" + empDetail.Department);
        }
        private static void getEmployeeDetailsFirstNameAscAndSalaryDes()
        {
            var employeeData = employees.OrderBy(fName => fName.FirstName).ThenByDescending(salary => salary.Salary);
            foreach (var employee in employeeData)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary:" + employee.Salary);
                Console.WriteLine("JoiningDate:" + employee.JoiningDate);
                Console.WriteLine("DEpartment:" + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getFirstNameDescending()
        {
            var firstName = employees.OrderByDescending(fName => fName.FirstName);
            foreach (var emp in firstName)
            {
                Console.WriteLine("\n");
                Console.WriteLine("First Name : " + emp.FirstName);
            }
        }
        private static void getFirstNameAscending()
        {
            var firstName = employees.OrderBy(fName => fName.FirstName);
            foreach (var emp in firstName)
            {
                Console.WriteLine("\n");
                Console.WriteLine("First Name : " + emp.FirstName);
            }
        }
        private static void getFirstNameAndDateOfJoining()
        {
            var employeeData = from Employee in employees select new { Employee.FirstName, Employee.JoiningDate };
            foreach (var emp in employeeData)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + emp.FirstName);
                Console.WriteLine("Joinig Year:" + emp.JoiningDate.Year);
                Console.WriteLine("Joinig Month:" + emp.JoiningDate.Month);
                Console.WriteLine("Joinig Date:" + emp.JoiningDate.Day);
            }
        }
        private static void getLengthofFirstName()
        {
            var employeeName = from Employee in employees select new { Employee.FirstName };
            foreach (var firstName in employeeName)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Length of FirstName:" + firstName.FirstName.Length);
            }
        }
        private static void getUniqueDepartment()
        {
            var department = from Employee in employees select new { Employee.Department };
            var uniqueDepartment = department.Distinct();
            foreach (var dept in uniqueDepartment)
            {
                Console.WriteLine(dept.Department);
            }
        }
        private static void getFirstNameInLowerCase()
        {
            var employeeName = from Employee in employees select new { Employee.FirstName };
            foreach (var firstName in employeeName)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + firstName.FirstName.ToLower());
            }
        }
        private static void getFirstNameInUpperCase()
        {
            var employeeName = from Employee in employees select new { Employee.FirstName };
            foreach (var firstName in employeeName)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + firstName.FirstName.ToUpper());
            }
        }
        private static void getFullNameofEmployee()
        {
            var fullNameEmployee = from Employee in employees select new { Employee.FirstName, Employee.LastName };
            foreach (var name in fullNameEmployee)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FullName:" + name.FirstName + " " + name.LastName);
            }
        }
        private static void getEmployeeDetails()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:" + employee.FirstName);
                Console.WriteLine("LasrName:" + employee.LastName);
                Console.WriteLine("Salary:" + employee.Salary);
                Console.WriteLine("JoiningDate:" + employee.JoiningDate);
                Console.WriteLine("DEpartment:" + employee.Department);
                Console.WriteLine("\n");
            }
        }
    }
}
