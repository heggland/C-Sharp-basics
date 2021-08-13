using System;
using System.Collections.Generic;
using System.Linq;

namespace dictonaries
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees =
            {
                // using string as key, int ID is recommended
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            /*
             * List all entries
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine($"Key: {keyValuePair.Key}");

                Employee employeeValue = keyValuePair.Value;

                Console.WriteLine($"Employee Name: {employeeValue.Name}, Role: {employeeValue.Role}, Salery: {employeeValue.Salary}");
            }
            */

            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            } // else..

            string KeyToRemove = "Intern";
            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine($"Person was removed: {KeyToRemove}");
            } //else..

            // list one
            string key = "HR";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine($"Employee Name: {empl.Name}, Role: {empl.Role}, Salery: {empl.Salary}");
            }
            else
            {
                Console.WriteLine($"No employee found with this this key {key}");
            }

            /*
             * Alternative way to list 
            Employee result = null;
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine($"Employee Name: {result.Name}, Role: {result.Role}, Salery: {result.Salary}");
            }
            else
            {
                Console.WriteLine($"No employee found with this this key {key}");
            }
            */

        }
    }
}
