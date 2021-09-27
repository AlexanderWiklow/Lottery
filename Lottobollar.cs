using System.Threading;
using System;

namespace Lottobollar
{
    class Program
    {
        static void Main(string[] args)
        {
            // En slumptalsgenerator för att få random nummer till våra lottobollar
            Random slumptalsgenerator = new Random();
            int[] användarensTal = new int[10];
            int slumptal1 = slumptalsgenerator.Next(1, 25);
            int slumptal2 = slumptalsgenerator.Next(1, 25);
            int slumptal3 = slumptalsgenerator.Next(1, 25);
            int[] slumpTal = new int[3] { slumptal1, slumptal2, slumptal3 };



            // Välkomnar användaren samt lägger till lite fördröjning mellan meddelanden

            Console.WriteLine("Welcome to Lottobollar!");
            Thread.Sleep(1000);
            Console.WriteLine("Win up to 200,000£!");
            Thread.Sleep(1000);
            Console.WriteLine("Match any of \"YOUR NUMBERS\" to either one of the \"WINNING NUMBERS\"");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Lets GO!");
            Console.WriteLine("=======================");

            // Ber användaren om att skriva in 10 stycken tal och sparar i en array

            Console.WriteLine("Please enter 10 numbers:");
            Console.WriteLine();

            // For-loop för att gå igenom varje plats i arrayen användarensTal och ger det värde som användaren skriver in

            for (int i = 0; i < användarensTal.Length; i++)
            {
                Console.Write("Number:");
                string svar = Console.ReadLine();
                int värde = Convert.ToInt32(svar);
                användarensTal[i] = värde;

                // En enklare form av felhantering. OM användaren skriver in ett tal under 1 eller över 25 så kommer vi hamna i denna if-loop som då skriver ut till användaren att skriva in ett annat tal. Arrayen sätts då tillbaka ett steg.

                if (användarensTal[i] < 1 || användarensTal[i] > 25)
                {
                    Console.WriteLine("Please enter a number between 1 and 25:");
                    i--;
                }

            }

            // När användaren skrivit in 10 tal börjar spelet

            Console.WriteLine();
            Console.WriteLine("All the numbers have been selected lets see if anyone takes home the big jackpot!");
            Console.WriteLine();

            // Nu ska ett tal slumpas fram, går igenom for-loopen och skriver ut till användaren. 

            Console.Write("And the winning numbers are");
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }

            Console.Write(" {0}!", slumptal1);
            Thread.Sleep(1000);
            Console.Write(" {0}!", slumptal2);
            Thread.Sleep(1000);
            Console.Write(" {0}!", slumptal3);

            Console.WriteLine();
            Thread.Sleep(1000);

            int antalVinster = 0;

            // Går igenom varje värde i arrayen användarens tal

            foreach (var itemA in användarensTal)
            {


                // Jämför varje värde i arrayen med värdet i slumpTal

                foreach (int itemB in slumpTal)
                {
                    
                    if (itemB == itemA)
                    {
                        // Ökar denna mätare med 1 varje gång värdet i itemB är samma som värdet i itemA
                        antalVinster = 1;
                        antalVinster++;
                    }
                }
            }

            // Beroende på hur många vinster användaren har så finns 4 olika alternativ
            if (antalVinster == 1)
            {
                Console.WriteLine("=======================================================================================================");
                Console.WriteLine("CONGRATULATIONS! you had 1/3 winning numbers on your card so you win tonights tier 3 prize of 50,000£!");
                Console.WriteLine("=======================================================================================================");
            }
            if (antalVinster == 2)
            {
                Console.WriteLine("=======================================================================================================");
                Console.WriteLine("CONGRATULATIONS! you had 2/3 winning numbers on your card so you win tonights tier 2 prize of 50,000£!");
                Console.WriteLine("=======================================================================================================");
            }

            if (antalVinster == 3)
            {
                Console.WriteLine("=======================================================================================================");
                Console.WriteLine("YOU JUST HIT THE JACKPOT! You scored 3/3 winning numbers making you the winner of the top prize of 200,000£! ");
                Console.WriteLine("=======================================================================================================");
            }
            else if (antalVinster == 0)
            {
                Console.WriteLine("Sorry! Luck wasn't on your side this time!");
            }

            // Tackar användaren och avslutar spelet
            Console.WriteLine();
            Console.WriteLine("Thanks for playing and welcome again next time!");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Press any key to quit the program...");
            Console.ReadKey();

        }
    }
}
