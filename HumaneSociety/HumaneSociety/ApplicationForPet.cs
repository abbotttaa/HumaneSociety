using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class ApplicationForPet
    {
        List<string> choices = new List<string>();
        public void SurrenderPromptAnimalType()
        {
            Console.WriteLine("What kind of animal? (1) Dog, (2) Cat, (3) Bird, (4) Rabbit, and (5) Ferret.");
            choices.Add(Console.ReadLine());
        }
        public void SurrenderPromptShots()
        {
            Console.WriteLine("Is he/she up to date on his/her shots? (1) Yes (2) No.");
            choices.Add(Console.ReadLine());
        }
        public List<string> SurrenderPromptFeeding()
        {
            Console.WriteLine("How much food should he/she eat a week? (1) 1 bag, (2) 2 bags, (3) 3 bags.");
            choices.Add(Console.ReadLine());
            return choices;
        }
        public void AdoptPromptAnimalType()
        {
            Console.WriteLine("What kind of animal did you have in mind? (1) Dog, (2) Cat, (3) Bird, (4) Rabbit, (5) Ferret or (6) didn't have one in mind");
            choices.Add(Console.ReadLine());
        }
        public void AdoptPromptShots()
        {
            Console.WriteLine("Are you looking for a pet who's up to date on shots? (1) Yes (2) No.");
            choices.Add(Console.ReadLine());
        }
        public void AdoptPromptFeeding()
        {
            Console.WriteLine("How often are you okay with buying food for your pet? Some eat more then others! (1) 1 bag a week (2) 2 bags a week or (3) 3 bags a week.");
            choices.Add(Console.ReadLine());
        }
        public void AdoptPromptKids()
        {
            Console.WriteLine("How kid friendly should he/she be? (1) Very, (2) Middle of the road, or (3) Not really.");
            choices.Add(Console.ReadLine());
        }
        public List<string> AdoptPromptHoldingPet()
        {
            Console.WriteLine("Are you looking for a pet you can hold? (1) Yes (2) No.");
            choices.Add(Console.ReadLine());
            return choices;
        }

    }
}
