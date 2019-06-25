//grand circus
//deliverable_two
//fun places to go
//cody shanley 2019

using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMood, numPeople;

            //get input from user
            Console.WriteLine("Hello user, what are you in the mood for?\nHere are your options: \n");
            Console.WriteLine("1) Action\n2) Chill times\n3) Danger\n4) Good food");
            numMood = int.Parse(Console.ReadLine());

            Console.WriteLine("How many people are you bringing with you?");
            numPeople = int.Parse(Console.ReadLine());

            string mood = "";
            string activity = "";
            string transportation = "";

            //create string snippets for final sentence based on user input
            if (numMood == 1)
            {
                mood = "action";
                activity = "stock car racing";
            }
            else if (numMood == 2)
            {
                mood = "chill times";
                activity = "hiking";
            }
            else if (numMood == 3)
            {
                mood = "danger";
                activity = "skydiving";
            }
            else if (numMood == 4)
            {
                mood = "good food";
                activity = "to Taco Bell";
            }

            if (numPeople == 0)
            {
                transportation = "sneakers!";
            }
            else if (numPeople >= 1 && numPeople <= 4)
            {
                transportation = "a sedan!";
            }
            else if (numPeople >= 5 && numPeople <= 10)
            {
                transportation = "a Volkswagen bus!";
            }
            else if (numPeople > 10)
            {
                transportation = "an airplane!";
            }

            //output
            Console.WriteLine("Okay if you're in the mood for " + mood + ", then you should go " + activity + " and travel in " + transportation);

        }
    }
}
