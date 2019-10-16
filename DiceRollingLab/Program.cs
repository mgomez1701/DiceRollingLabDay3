using System;

namespace DiceRollingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true; // lising out my boo variable i will use later//

            // user input asking how many sides to two dice there are//
            Console.WriteLine($"How many sides does a pair of rolling die have?");
            // storing the string into a byte. Byte are smaller and dice dont go high//
            int answer = byte.Parse(Console.ReadLine());
            //calling my preRoll method that asks the user to roll// 

            while (keepGoing)
            {
                preRoll(); // not storing anything here//
                string operation = Console.ReadLine();

                switch (operation)
                {

                    case "Y":
                        keepGoing = true;

                    case "n"
                    case "no" 
                        keepGoing = false;
                    default:
                        preRoll();
                }

            }


        }

        public static void preRoll()
        {
            Console.Write($"Would you like to roll the dice y/n? ");

        }

    }

    public static int diceRoll(int number1, int number2)
    {

    }
