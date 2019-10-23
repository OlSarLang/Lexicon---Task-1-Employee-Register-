using System;

//Uppgift 1: Programklassen, Registryklassen, och Personklassen (för individen)
//Uppgift 2: Programklassen:
//           Registryklassen:
//           Personklassen:

namespace PersonalregisterÖvning1
{
    class Program
    {
        //Class variable reg is initialized as empty ready to be used be the rest of the program.
        static Registry reg = new Registry();
        static void Main(string[] args)
        {
            //Creates 3 dummy employees
            reg.addEmployee("Oliver", 24000.0);
            reg.addEmployee("Adam", 18000.0);
            reg.addEmployee("Eva", 32000.0);
            
            //The following function starts the program itself, the rest is self-explanatory
            AskWhatToDo();
        }

        static public void AskWhatToDo()
        {
            Console.Write("What do you want to do?\nPress '1' to show the registry\nPress '2' to add a new employee\n");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                EditEmployees(); //Line 52
            }
            else if (choice == "2")
            {
                AddPerson(); //Line 76
            }
            else
            {
                Console.WriteLine("Invalid Input, try again\n");
                AskWhatToDo();
            }
        }

        static void ShowRegistry()
        {
            foreach(Person p in reg.getEmploymentList())
            {
                Console.WriteLine($"{reg.getEmploymentList().IndexOf(p) + 1} {p.getName()} with a salary of {p.getSalary()}");
            }
        }

        public static void EditEmployees()
        {
            ShowRegistry();
            Console.Write("Press '1' to add employee\n Press '2' to remove employees\nPress 'b' to go back.\n");
            // int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                AddPerson();
            }
            else if (choice == "2")
            {
                RemovePerson();
            }
            else if (choice == "b")
            {
                AskWhatToDo();
            }
            else
            {
                Console.WriteLine("Invalid Input, try again\n");
                EditEmployees();
            }
        }
        static public void AddPerson()
        {
            Person newPerson = new Person();
            newPerson.setName(AskName());
            newPerson.setSalary(AskSalary());

            reg.addEmployee(newPerson);
            EditEmployees();
        }

        public static string AskName()
        {
            Console.Write("Type the name of the new employee.\n");
            string choice = Console.ReadLine();
            if (choice != null)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again\n");
            }
            return AskName();
        }
        public static double AskSalary()
        {
            double value;
            Console.Write("Type the salary.\n");
            string input = Console.ReadLine();

            if (double.TryParse(input, out value))
            {
                return value;
            } else
            {
                Console.WriteLine("Invalid input. Try again\n");
            }
            return AskSalary();
        }

        public static void RemovePerson()
        {
            if(reg.getEmploymentList().Count == 0)
            {
                Console.WriteLine("There are no more employees to remove.");
                EditEmployees();
            }
            else
            {
                ShowRegistry();
                Console.Write("Type the number of the person you wish to remove.\n Press 'b' to go back.\n");
                string choice = Console.ReadLine();
                int value = 0;
                bool successfullyParsed = int.TryParse(choice, out value);
                if (choice == "b")
                {
                    EditEmployees();
                }
                else if (successfullyParsed && value <= reg.getEmploymentList().Count)
                {
                    reg.removeEmployee(value);
                    RemovePerson();
                }
                else
                {
                    Console.WriteLine("Invalid Input, try again\n");
                    RemovePerson();
                }
            }
        }
    }
}
