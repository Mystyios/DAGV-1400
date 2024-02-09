using System;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
		int randNum = rnd.Next(1, 10);
		Console.WriteLine("Can you guess what number I'm thinking of: ");
		
		bool guessed = false;
		int numGuess = 0;
		while (guessed == false)
		{
			Console.WriteLine(randNum);
			int guessedNum = Convert.ToInt32(Console.ReadLine());
			if (guessedNum > randNum)
			{
				Console.WriteLine("Too High");
				numGuess++;
			}
			else if (guessedNum < randNum)
			{
				Console.WriteLine("Too Low");
				numGuess++;
			}
			else
			{
				guessed = true;
				numGuess++;
				Console.WriteLine("You Got It! It took " + numGuess + " Guesses");
			}
		}

        //:D(Happy)
    }
}
