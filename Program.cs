
namespace Lexicon_personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreatePersonellRegistry();
        }
        // method to create a new PersonellRegistry object using command line input
        static PersonellRegistry CreatePersonellRegistry()
        {
            Console.WriteLine("Enter name 11:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter wage 11:");
            int wage = int.Parse(Console.ReadLine());

            // Display the newly created PersonellRegistry object
            Console.WriteLine($"Name: {name}, Wage: {wage}");

            // Parse input data into a collection of PersonellRegistry objects
            List<PersonellRegistry> personellRegistries = new List<PersonellRegistry>();
            PersonellRegistry personellRegistry = new PersonellRegistry(name, wage);
            personellRegistries.Add(personellRegistry);

            // Add the new PersonalRegistry to the list with method AddPersonellRegistry and return it
            return AddPersonellRegistry(personellRegistries)
        }

        // Method to handle the list object from CreatePersonellRegistry and add it to the list
        static PersonellRegistry AddPersonellRegistry(List<PersonellRegistry> personellRegistries)
        {
            Console.WriteLine("Do you want to add another PersonellRegistry? (yes/no)");
            string answer = Console.ReadLine().ToLower();
            while (answer == "yes")
            {
                Console.WriteLine("Enter name 22:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter wage 22:");
                int wage = int.Parse(Console.ReadLine());
                // Create a new PersonellRegistry object and add it to the list
                PersonellRegistry personellRegistry = new PersonellRegistry(name, wage);
                personellRegistries.Add(personellRegistry);
                // Ask if the user wants to add another one
                Console.WriteLine("Do you want to add another PersonellRegistry? (yes/no)");
                answer = Console.ReadLine().ToLower();
            }
            // Display all PersonellRegistry objects in the list
            DisplayPersonellRegistries(personellRegistries);
            return personellRegistries[0]; // Return the first object in the list as an example
        }


        // method to display all PersonellRegistry objects in a list
        static void DisplayPersonellRegistries(List<PersonellRegistry> personellRegistries)
        {
            Console.WriteLine("Personell Registries 333:");
            foreach (var personellRegistry in personellRegistries)
            {
                Console.WriteLine($"Name: {personellRegistry.name}, Wage: {personellRegistry.wage}");
            }
        }
    }
}
