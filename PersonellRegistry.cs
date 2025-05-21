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
        // method to add a new PersonellRegistry object to the list
        public void AddPersonellRegistry(string name, int wage)
        {
            PersonellRegistry personellRegistry = new PersonellRegistry(name, wage);
            List<PersonellRegistry> personellRegistries = new List<PersonellRegistry>();
            personellRegistries.Add(personellRegistry);
        }
        // method that creates a new PersonellRegistry object and adds it to the list
        public void AddPersonellRegistry()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter wage:");
            int wage = int.Parse(Console.ReadLine());
            PersonellRegistry personellRegistry = new PersonellRegistry(name, wage);
            List<PersonellRegistry> personellRegistries = new List<PersonellRegistry>();
            personellRegistries.Add(personellRegistry);

            // display the added PersonellRegistry object
            //Console.WriteLine($"Added PersonellRegistry: Name: {personellRegistry.name}, Wage: {personellRegistry.wage}");
        }

        // method that displays all the personell registries in the list and asks user if he wants to add additional users
        public void DisplayPersonellRegistries(List<PersonellRegistry> personellRegistries)
        {
            Console.WriteLine("Personell Registries:");
            foreach (var personellRegistry in personellRegistries)
            {
                Console.WriteLine($"Name: {personellRegistry.name}, Wage: {personellRegistry.wage}");
            }
            // ask if user wants to add more registries and while the user says yes keep adding registries
            Console.WriteLine("Do you want to add more registries? (yes/no)");
            string answer = Console.ReadLine().ToLower();
            while (answer == "yes")
            {
                AddPersonellRegistry();
                Console.WriteLine("Do you want to add more registries? (yes/no)");
                answer = Console.ReadLine().ToLower();
            }
            // display the final list of registries
            Console.WriteLine("Curren list looks like this:");
            foreach (var personellRegistry in personellRegistries)
            {
                Console.WriteLine($"Name: {personellRegistry.name}, Wage: {personellRegistry.wage}");
            }
        }
    }
}
