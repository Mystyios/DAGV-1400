using System;

public class Program
{
    public void Main()
    {
      //Asks the user to input a temperature in Celsius
        Console.WriteLine("Please Enter the Current Temperature in Celsius: ");
        int temp = Convert.ToInt32(Console.ReadLine());

      //Determines what message to respond with depending on if the temperature is greater or less than 30.
        if (temp < 0)
        {
            Console.WriteLine("It's freezing, stay inside and keep warm!");
        }
        else if (temp >= 1 && temp <= 10)
        {
            Console.WriteLine("It's a bit chilly, I'd reccomend a coat");
        }
		else if (temp >= 11 && temp <= 20)
		{
			Console.WriteLine("It's cool outside, you should take a light jacket");
		}
		else if (temp >= 21 && temp <= 30)
		{
			Console.WriteLine("It's a nice warm day, enjoy the weather");
		}
		else if (temp >= 31 && temp <= 40)
		{
			Console.WriteLine("It's pretty hot outside, stay hydrated and wear sunscreen");
		}
		else
		{
			Console.WriteLine("It is absurdly hot, drink plenty of water and avoid the sun!");
		}
		
        
    }
}
