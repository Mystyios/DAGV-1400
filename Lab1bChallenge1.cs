using System;

public class Program
{
    public void Main()
    {
      //Asks the user to input a temperature in Celsius
        Console.WriteLine("Please Enter the Current Temperature in Celsius: ");
        int temp = Convert.ToInt32(Console.ReadLine());

      //Determines what message to respond with depending on if the temperature is greater or less than 30.
        if (temp > 30)
        {
            Console.WriteLine("You should stay hydrated and avoid too much sunlight");
        }
        else
        {
            Console.WriteLine("It is a nice day, you should enjoy the weather");
        }
        
    }
}
