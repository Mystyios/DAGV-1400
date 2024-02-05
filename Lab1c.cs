using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("How many rows for the pyramid: ");
		int numRows = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		
		for (int i = 1; i <= numRows; i++)
		{
			for (int x = 1; x <= i; x++)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
	}
}
