using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace HumaneSociety
{
    class Ferrets : Animal
    {
        public string species;
        
        
        public Ferrets(string species)
        {
            this.species = species;
        }
    }
}
