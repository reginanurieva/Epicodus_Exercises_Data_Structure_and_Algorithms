using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    Console.WriteLine("1. Computer Guess 2. User Guess");
    string mode = Console.ReadLine();
    if (mode == "1")
    {
      Console.WriteLine("Would You like to play the higher-lower game? [y] for 'yes' [n] for 'No'");
      string answer = Console.ReadLine().ToLower();
      if (answer.Equals("y"))
      {
        Console.WriteLine("Okay!");
        Random rand = new Random();


        //get a random value ( 0 <= random value < 1)
        // rand.Next returns (randomValue * 10000) % 101 => from 0 to 100
        answer = "";
        int upperBound = 101;
        int lowerBound = 1;
        int guessedNumber = 0;

        while (answer != "correct")
        {
          guessedNumber = rand.Next(lowerBound, upperBound);
          Console.WriteLine("Is your number higher or lower than " + guessedNumber + "? (Higher/Lower/Correct)");
          answer = Console.ReadLine().ToLower();
          if (answer == "lower")
          {
            upperBound = guessedNumber;
          }
          else if (answer == "higher")
          {
            lowerBound = guessedNumber+1;
          }
          else if (answer != "correct")
          {
            Console.WriteLine("Enter a valid answer");
          }
          //if answer == correct
          else
          {
            while (true) {
              Console.WriteLine("Great! Would you like to play again? [y] for 'yes' [n] for 'No'");
              string keepPlaying = Console.ReadLine().ToLower();
              if (keepPlaying == "y")
              {
                answer = "";
                upperBound = 101;
                lowerBound = 1;
                guessedNumber = 0;
                break;
              }
              else if (keepPlaying == "n")
              {
                Console.WriteLine("Program quits");
                break;
              }
              else
              {
                Console.WriteLine("Enter a valid value");
              }
            }
          }
        }

      }
      else if (answer.Equals("n"))
      {
        Console.WriteLine("Program quits");
      }
      else
      {
        Console.WriteLine("Enter a valid value");
      }
    }
    else if (mode == "2")
    {
      Random rand = new Random();
      int targetNumber = rand.Next(1, 101);
      int userGuessNumber = 0;
      bool parseResult;
      while(targetNumber != userGuessNumber)
      {
        Console.WriteLine("Try to guess the Computer number!");
        userGuessNumber = 0;
        // int userGuessNumber = int.Parse(Console.ReadLine());
        parseResult = int.TryParse(Console.ReadLine(), out userGuessNumber);
        if (parseResult == false || (parseResult == true && userGuessNumber < 1) || (parseResult == true && userGuessNumber > 100) )
        {
          //error message
          Console.WriteLine("Please enter a valid number!");
        }
        else
        {
          //do something with userGuessNumber
          if (targetNumber > userGuessNumber)
          {
            Console.WriteLine("My number is higher than " + userGuessNumber);
          }
          else if (targetNumber < userGuessNumber)
          {
            Console.WriteLine("My number is lower than " + userGuessNumber);
          }
          else
          {
            Console.WriteLine("That is the correct number!");
            while (true) {
              Console.WriteLine("Would you like to play again? [y] for 'yes' [n] for 'No'");
              string keepPlaying = Console.ReadLine().ToLower();
              if (keepPlaying == "y")
              {
                targetNumber = rand.Next(1, 101);
                userGuessNumber = 0;
                break;
              }
              else if (keepPlaying == "n")
              {
                Console.WriteLine("Program quits");
                break;
              }
              else
              {
                Console.WriteLine("Enter a valid value");
              }
            }
          }
        }
      }
      // string compGenerated = "";
      // int upperBound = 101;
      // int lowerBound = 1;
      // int guessedNumber = 0;
    }
    else
    {
      Console.WriteLine("Choose valid option number");
    }
  }
}

// for (int i = 0; i<5; i++) {
//   Console.WriteLine(i);
// }
