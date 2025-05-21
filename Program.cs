
namespace Lexicon_personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of PersonellRegistry
            PersonellRegistry personellRegistry = new PersonellRegistry("", 0);
            // Call the method to add a new PersonellRegistry object to the list
            personellRegistry.AddPersonellRegistry();
            // Call the method to display all PersonellRegistry objects in the list
            personellRegistry.DisplayPersonellRegistries(new List<PersonellRegistry>());
        }
    }
}
