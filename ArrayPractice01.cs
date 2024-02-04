using System;
					
public class Program
{
	public void Main()
	{
    //02 Arrays Foreach Loops
		string[] cars = {"Mustang", "Camero", "HellCat", "Corvette", "Viper", "McCleran"};
		Console.WriteLine(cars.Length);
		foreach(var car in cars)
		{
			Console.WriteLine("I love my " + car + ".");
		}

    //03 Arrays For Loops
    string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
		
		for(var i = 0 ; i < playerTypes.Length ; i++)
		{
			playerTypes[i] = "Queen";
		}
		
		foreach(var playerType in playerTypes)
		{
			Console.WriteLine(playerType);
		}
	}
}
