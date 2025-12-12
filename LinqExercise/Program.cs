using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
                Console.WriteLine($"Sum:{numbers.Sum()}");
            //TODO: Print the Average of numbers
                Console.WriteLine($"Average:{numbers.Average()}");
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine($"ascending:{numbers.Max()}");
            foreach (var number in numbers )
            {
                Console.WriteLine(number);
            }   
            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine($"descending:{numbers.Min()}");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }    
            //TODO: Print to the console only the numbers greater than 6
             var greaterThanSix = numbers.Where(n => n > 6).OrderByDescending(n => n);
             
             Console.WriteLine("Greater than Six");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("First 4 asc");
            foreach (var number in numbers.Take(4))
            {
                Console.WriteLine(number);
            }    
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 50;
            Console.WriteLine("50");
            foreach (var number in numbers.OrderByDescending(n => n))
            {
                Console.WriteLine(numbers);
            }    
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            employees.Where(employee => employee.FirstName.StartsWith('C') || employee.FirstName.StartsWith('S')).OrderBy(employees => employees.FirstName);
            Console.WriteLine("C or S Employees");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName);
            }   
            
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.Where(employees => employees.Age > 26).OrderBy(employee => employee.Age).ThenBy(employees => employees.FirstName);
            Console.WriteLine("OverTwenty Six");
            foreach (var employee in overTwentySix)
            {
                Console.WriteLine($"Fullname: {employee.FullName} Age: {employee.Age} ");
            }    
            
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var years = employees.Where(x => x.YearsOfExperience <= 10 && x.Age >35);
            Console.WriteLine($"Sum:{years.Sum(employee => employee.YearsOfExperience)}");
            
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var avgyears  = employees.Average(employee => employee.YearsOfExperience);
            Console.WriteLine($"Average:{avgyears}");
            
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("firstName", "lastName", 56, 1)).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Age}");
            }
            Console.WriteLine();
            
            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
