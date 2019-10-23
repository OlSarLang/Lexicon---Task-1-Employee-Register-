using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalregisterÖvning1
{

    //The Person class contains the information for each person who is in turn within the Registry.
    class Person
    {
        string name = "";
        double salary;

        public Person()
        {
            this.name = "unknown";
            this.salary = 0.0;
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getSalary()
        {
            return salary;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }



    }
}
