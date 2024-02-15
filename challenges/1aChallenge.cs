using System;
					
public class Program
{
	public static void Main()
	{
		int myInt = 5;
		float myFloat = 2.55F;
		bool myBool = true;
		Console.WriteLine("Please enter your name: ");
		string myString = Console.ReadLine();
		Console.WriteLine("Hello " + myString);
		Console.WriteLine(myInt);
		Console.WriteLine(myFloat);
		Console.WriteLine(myBool);
		Console.WriteLine(myString);
		Console.WriteLine(myInt * myFloat / 3 + 2 - 1);
		
		Console.WriteLine("Please Enter a number: ");
		int userNum = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Your number plus 5 is: " + (userNum + 5));
	}
}
