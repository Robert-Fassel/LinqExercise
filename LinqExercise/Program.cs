using System;
using System.Collections.Generic;
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
            Console.WriteLine(numbers.Sum(x => x));
            Console.WriteLine("-----------");

            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average(x => x));
            Console.WriteLine("-----------");

            //TODO: Order numbers in ascending order and print to the console
            IEnumerable<int> nums = numbers.OrderBy(x => x);
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------");

            //TODO: Order numbers in decsending order and print to the console
            IEnumerable<int> nums2 = numbers.OrderByDescending(x => x);
            foreach (int num in nums2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------");

            //TODO: Print to the console only the numbers greater than 6
            IEnumerable<int> sevenUp = numbers.Where(x => x > 6);
            foreach (int numset in sevenUp)
            {
                Console.WriteLine(numset);
            }
            Console.WriteLine("-----------");
            //TODO: Order numbers in any order (acsending or desc)
            //but only print 4 of them **foreach loop only!**
            var newList = numbers.Take(4).OrderBy(x => x);
            foreach (var i in newList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------");
            //TODO: Change the value at index 4 to your age,
            //then print the numbers in decsending order

            numbers[4] = 37;
            var plusAge = numbers.OrderByDescending(x => x);
            foreach (var a in plusAge)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-----------");
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to
            //the console only if their FirstName starts with a C OR
            //an S and order this in ascending order by FirstName.
            var cSNames = employees.Where(emps => emps.FirstName[0] == 'C'
            || emps.FirstName[0] == 'S').OrderBy(emps => emps.FirstName);
            foreach (var nam in cSNames)
            {
                Console.WriteLine(nam.FullName);
            }
            Console.WriteLine("-----------");
            //TODO: Print all the employees' FullName
            //and Age who are over the age 26 to the console
            //and order this by Age first and then by FirstName in the same result.
            var older = employees.Where(age => age.Age > 26).OrderBy(age => age.Age)
                .ThenBy(age => age.FirstName);
            foreach (var old in older)
            {
                Console.WriteLine(old.FullName);
            }
            Console.WriteLine("-----------");
            //TODO: Print the Sum and then the Average of the
            //employees' YearsOfExperience if their YOE is less
            //than or equal to 10 AND Age is greater than 35.
            var exp = employees.Where(year => year.YearsOfExperience <= 10 &&
            year.Age > 35);
            Console.WriteLine($"Sum: {exp.Sum(year => year.YearsOfExperience)}");
            Console.WriteLine($"Average: {exp.Average(year => year.YearsOfExperience)}");
            Console.WriteLine("-----------");
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Herc", "Poirot", 70, 20)).ToList();
            foreach(var newEmp in employees)
            {
                Console.WriteLine(newEmp.FullName);
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
