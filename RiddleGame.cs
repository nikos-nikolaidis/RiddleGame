using System;

namespace TheRiddleGame
{
    class Program
    {
        static void Main(string[] args) //this is a method
        {
            string HiddenWorld = "silence";
            string guess = "";
            int guessCount = 0;
            int guessLimit= 3;
            bool outOfGyesses = false;

           


            Console.WriteLine("Hello wellcome to the game ' press Enter ' to play ");
            Console.ReadLine();
            Console.Write("So Enter your name and ' press Enter ':");
            String name = Console.ReadLine(); 
            Console.WriteLine("Hello " + name +" wellcome to the riddle game ");
            Console.ReadLine();
            Console.WriteLine("You have 3 attempts " +  name + " to find the hidden word 'press Enter'");
            Console.ReadLine();
            Console.WriteLine(" I'm strong as a rock but a word can destroy me. \n  What am I? \n 'press Enter'");
            Console.ReadLine();

            while (guess != HiddenWorld &&  !outOfGyesses)
            {
                if ( guessCount < guessLimit  )
                {
                    Console.Write("Enter the hidden world:");
                    guess = Console.ReadLine();
                    guessCount++;


                } else 
                {
                    outOfGyesses = true;
                
                }
              

            }

            if (outOfGyesses)
            {
                Console.WriteLine("Sorry " + name + " you lose try next time");

            }
            else
            {
                Console.WriteLine("Congratulations " + name + " you find the riddle ");

            }



            Console.ReadLine(); //wait for user to type a text
        }

       
    }
}