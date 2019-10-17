using System;

namespace DiceRollingLab
{
    class Program
    {

        static void Main(string[] args)
        {
            bool keepGoing = true; // lising out my bool variable i will use later//
            Random random = new Random(); // using a random generator code i found online//
            
    
            while (keepGoing)
            {
                askQuestion();  // calling method asking y/n if they want to roll dice//
                string userInput = Console.ReadLine();
                userInput.ToLower();

                // using a switch statment to ask for the user input on y/n
                if (userInput == "yes" )
                {
                   
                    Console.WriteLine($"Roll One: ");
                    Console.WriteLine("Dice 1: " + random.Next(1, 7)); // setting the min and max of 1 & 6 //
                    Console.WriteLine("Dice 2: " + random.Next(1, 7));
                    keepGoing = true;
                }
                else if (userInput == "y")
                {
            
                    Console.WriteLine($"Roll One: ");
                    Console.WriteLine("Dice 1: " + random.Next(1, 7)); // setting the min and max of 1 & 6 //
                    Console.WriteLine("Dice 2: " + random.Next(1, 7));
                    keepGoing = true;
                }
                else
                {
                    Console.WriteLine($"Better luck next time....");
                    return;
                }

            }

        }

        public static void askQuestion()
        {
            Console.Write($"Would you like to roll the dice y/n? ");
        }
        public static int askQuestionTwo(string message)
        {
            Console.Write(message);
            //ask for user input//
            // converting to int with Parse and returning//
            return  int.Parse(Console.ReadLine());
            
        }
     

    }
}

    