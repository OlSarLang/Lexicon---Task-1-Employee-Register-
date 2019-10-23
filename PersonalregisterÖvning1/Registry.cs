using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalregisterÖvning1
{

    //The Registry keeps a list of all the employees. It is used to show, create, and remove from the list.
    class Registry
    {
        List<Person> employmentList;

        public Registry()
        {
            this.employmentList = new List<Person>();
        }

        public void addEmployee(string name, double salary)
        {
            Person person = new Person(name, salary);
            employmentList.Add(person);
        }

        public void addEmployee(Person person)
        {
            employmentList.Add(person);
        }

        public List<Person> getEmploymentList()
        {
            return employmentList;
        }

        public void removeEmployee(int i)
        {
            employmentList.RemoveAt(i - 1);
            
        }

    }
}
