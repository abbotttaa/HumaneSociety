using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dogs : Animal
    {
        public string species;


        public Dogs(string species)
        {
            this.species = species;
        }
    }
}
