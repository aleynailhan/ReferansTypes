using System;
using System.Collections.Generic;
using System.Text;

namespace ReferansTypes
{
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
        public void Add(Employees employees)
        {
            Console.WriteLine(employees.EmployeeNumber);
        }
    }
}
