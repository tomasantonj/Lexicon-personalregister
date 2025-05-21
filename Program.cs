
namespace Lexicon_personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of PersonellRegistry
            PersonellRegistry personellRegistry = new PersonellRegistry("", 0);
            // Call the method that runs the loops of adding and displaying PersonellRegistry objects
            personellRegistry.AddPersonellRegistry();
        }
    }
}
