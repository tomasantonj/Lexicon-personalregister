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
    }
}
