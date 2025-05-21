using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_personalregister
{
    internal class PersonellRegistry
    {
        // Properties on the PersonellRegistry class
        public string name;
        public int wage;

        // Constructor to initialize the properties of the PersonellRegistry class
        public PersonellRegistry(string name, int wage)
        {
            this.name = name;
            this.wage = wage;
        }
        // constructor to add a new PersonellRegistry object to the list
        public void AddPersonellRegistry(string name, int wage)
        {

        }
        // overloaded constructor method that appends newly created PersonellRegistry objects to the list and prompts user for more input and displays the list and ends the program
        // TODO break this method into smaller methods for better readability and maintainability
        // TODO make sure you can add the same name twice without overwriting the first one
        // TODO using IO/filesystem save the list to a file and read it back in when the program starts
        public void AddPersonellRegistry()
        {
            // create a list to hold PersonellRegistry objects
            List<PersonellRegistry> personellRegistries = new List<PersonellRegistry>();

            // prompt user for input and run some checks on the input data to make sure it is valid
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            // run validateName method to check if name is valid
            name = ValidateName(name);

            Console.WriteLine("Enter wage:");
            // ask user for input for wage, and run check to verify it is a number
            string wageInput = Console.ReadLine();
            // run validateWage method to check if wage is valid
            int wage = ValidateWage(wageInput);

            // create a new PersonellRegistry object and add it to the list
            PersonellRegistry personellRegistry = new PersonellRegistry(name, wage);
            personellRegistries.Add(personellRegistry);

            // ask if user wants to add more registries
            Console.WriteLine("Do you want to add more registries? (yes/no)");
            string answer = Console.ReadLine();
            // check if answer is yes or no and run some checks on the input data to make sure it is valid
            while (answer.ToLower() != "yes" && answer.ToLower() != "no")
            {
                Console.WriteLine("Please enter a valid answer (yes/no):");
                answer = Console.ReadLine();
            }
            // TODO: Move logic to a separate method for better readability and maintainability
            while (answer.ToLower() == "yes")
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                // run validateName method to check if name is valid
                name = ValidateName(name);
                Console.WriteLine("Enter wage:");
                // ask user for input for wage, and run check to verify it is a number
                wageInput = Console.ReadLine();
                // run validateWage method to check if wage is valid
                wage = ValidateWage(wageInput);

                personellRegistry = new PersonellRegistry(name, wage);
                personellRegistries.Add(personellRegistry);
                Console.WriteLine("Do you want to add more registries? (yes/no)");
                // check if answer is yes or no and run some checks on the input data to make sure it is valid
                while (answer.ToLower() != "yes" && answer.ToLower() != "no")
                {
                    Console.WriteLine("Please enter a valid answer (yes/no):");
                    answer = Console.ReadLine();
                }
                answer = Console.ReadLine();
            } if (answer.ToLower() == "no")
            {
                // display current list items
                DisplayPersonellRegistries(personellRegistries);
            }
            else {
                // TODO add logic for handling answers that are other than yes or no
                // display current list items
                DisplayPersonellRegistries(personellRegistries);
            }
        }

        // method that handles input validation for the name property
        // TODO: improve logic to handle sur and last names, right now it requires a single 
        public string ValidateName(string name)
        {
            // check if name is empty or null or a not alphabethical string
            while (string.IsNullOrEmpty(name) || !name.All(char.IsLetter))
            {
                Console.WriteLine("Name must be a non-empty alphabetical string. Please enter a valid name:");
                name = Console.ReadLine();
            }
            return name;
        }
        // method that handles input validation for the wage property
        // it checks if it is an integer and if it is a positive number
        // TODO error handle why 0 is still allowed as input
        public int ValidateWage(string wageInput)
        {
            int wage;
            // check if wage is a number and run some checks on the input data to make sure it is valid
            while (!int.TryParse(wageInput, out wage) || wage < 0)
            {
                Console.WriteLine("Wage must be a number and larger than 0:");
                wageInput = Console.ReadLine();
            }
            return wage;
        }
        // method that displays all PersonellRegistry objects in the list
        public void DisplayPersonellRegistries(List<PersonellRegistry> personellRegistries)
        {
            Console.WriteLine("Personell Registries:");
            foreach (var personellRegistry in personellRegistries)
            {
                Console.WriteLine($"Name: {personellRegistry.name}, Wage: {personellRegistry.wage}");
            }
        }
    }
}