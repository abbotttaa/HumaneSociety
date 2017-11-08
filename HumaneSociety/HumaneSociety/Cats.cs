using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace HumaneSociety
{
    class Cats : Animal
    {
        public string species;


        public Cats(string species)
        {
            this.species = species;
        }
    }
}
