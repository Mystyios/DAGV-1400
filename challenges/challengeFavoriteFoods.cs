using System;

public class Program
{
    public void Main()
    {
      //Empty string for favorite foods
       string[] favFoods = {"", "", ""};
      //Asks for three favorite foods and stores them in favFoods array
		Console.WriteLine("What is your favorite food: ");
		favFoods[0] = Console.ReadLine();;
		Console.WriteLine("What is your second favorite food: ");
		favFoods[1] = Console.ReadLine();
		Console.WriteLine("What is your third favorite food: ");
		favFoods[2] = Console.ReadLine();

      //Writes a message for each food item
		foreach (string food in favFoods)
		{
			Console.WriteLine("I love " + food + "!");
		}
        //:D(Happy)
    }
}
