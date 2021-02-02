using System;

namespace ReferansTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "aleyna";
            person1.LastName = "ilhan";

            Customer customer = new Customer();
            customer.FirstName = "ahmet";
            customer.FirstName = person1.FirstName;
           // Console.WriteLine(customer.FirstName);

            Person person3 = customer;
            //Console.WriteLine(person3.FirstName);
            Employees employees = new Employees();
            employees.EmployeeNumber = 5;

            PersonManager personManager = new PersonManager();
            personManager.Add(employees);

            employees.FirstName = person1.FirstName;
            Console.WriteLine(employees.FirstName);
        }
    }
}
