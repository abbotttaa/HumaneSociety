using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class UI
    {
        public void PromptForExchange()
        {
            Console.WriteLine("Are you planning to adopt or drop off a pet today?");
        }
        public void GetPetInformation()
        {
            Console.WriteLine("What kind of animal? (1) Dog, (2) Cat, (3) Bird, (4) Rabbit, and (5) Ferret.");

            Console.WriteLine("What is your price range? Please list the most youre willing to pay.");

            Console.WriteLine("How much food should he/she eat a week?");

            Console.WriteLine("How kid friendly? (1) Very, (2) Middle of the road, or (3) Not really.");

            Console.WriteLine("Are you looking for a pet you can hold? (1) Yes (2) No.");
        }

    }
}
