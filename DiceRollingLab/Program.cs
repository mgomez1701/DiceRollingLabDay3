using System;

namespace DiceRollingLab
{
    class Program
    {

        static void Main(string[] args)
        {
            bool keepGoing = true; // lising out my bool variable i will use later//
            Random random = new Random(); // using a random generator code i found online//
            Console.WriteLine($"Welcome to the Regal Players Palace!");
    
            while (keepGoing)
            {
                askQuestion();  // calling 1st method asking y/n if they want to roll dice//
                string userInput = Console.ReadLine();
                userInput.ToLower();

                // using a if else statment to ask for the user input on y/n
                if (userInput == "yes" || userInput == "y" || userInput == "Y"|| userInput == "Yes") 
                {
                    int answer = askQuestionTwo($"How many sides does each dice have?"); // 2nd method being called //
                    if (answer == 6 ) // nesting an if within an if statment to make sure the user puts a valid number//
                    {
                        Console.WriteLine($"Rolling.... Here is what you rolled: ");
                        Console.WriteLine("Dice 1: " + random.Next(1, 7)); // setting the min and max of 1 & 7 since there are 6 sides //
                        Console.WriteLine("Dice 2: " + random.Next(1, 7)); // dice 2 //
                        string roll = Console.ReadLine(); // tired to attempt to display special messages .. maybe a switch statement//
                        
                        keepGoing = true;
                    }
                     else if (answer != 6) 
                     {
                        Console.WriteLine($"That is not correct. Think back to Monopoly days... How many sides should a dice have?");
                     }                   
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

    