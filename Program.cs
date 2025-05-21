
namespace Lexicon_personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of PersonellRegistry
            PersonellRegistry personellRegistry = new PersonellRegistry("", 0);
            // Call the method to add a new PersonellRegistry object to the list based on user input
            personellRegistry.AddPersonellRegistry();
        }
    }
}
