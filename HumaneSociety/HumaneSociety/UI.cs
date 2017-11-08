using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace HumaneSociety
{
    public class UI
    {
        ApplicationForPet appForPet = new ApplicationForPet();
        public void PromptForExchange()
        {
            Console.WriteLine("Are you planning to (1)adopt or (2)surrender a pet today?");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                GetPetInformationAdopting();
            }
            else if(choice == "2")
            {
                GetInformationSurrender();
            }
            else
            {
                Console.WriteLine("Huh?  Try again, this time please choose a provided option");
            }
        }
        public void GetPetInformationAdopting()
        {
            appForPet.AdoptPromptAnimalType();

            appForPet.AdoptPromptShots();

            appForPet.AdoptPromptFeeding();

            appForPet.AdoptPromptKids();

            appForPet.AdoptPromptHoldingPet();
        }
        public void GetInformationSurrender()
        {
            appForPet.SurrenderPromptAnimalType();

            appForPet.SurrenderPromptShots();

            appForPet.SurrenderPromptFeeding();

        }

    }
}
