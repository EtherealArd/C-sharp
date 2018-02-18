using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCode
{

    class Employee
    {
        public int Id { get; set; } = 1001;
        public string FirstName { get; set; } = "John";
        public string[] GetCountries() => new string[] { "Canada", "USA" };
    }
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name ?? throw new ArgumentNullException(name);
        public string GetFirstName()
        {
            //var parts = Name.Split(" ");
            return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
        }
        public string GetLastName() => throw new NotImplementedException();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string str = $"Emloyee name is {emp.FirstName}, id: {emp.Id}";
            string name = emp?.FirstName;
            var countries = new Dictionary<int, string> { [0] = "USA",
                [1] = "England" };
            var result = GetDivisionResults(17, 5);
            Console.WriteLine(result.Item1+" "+ result.Item2);
        }

        static (int, int) GetDivisionResults(int number, int divisor)
        {

            int quotient = number / divisor;
            int remainder = number % divisor;
            return (quotient, remainder);
        }



    }
}
