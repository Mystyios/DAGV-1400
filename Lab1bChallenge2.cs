using System;

public class Program
{
    public void Main()
    {
        //Asks User to enter exam score percentage
        Console.WriteLine("Please Enter Your Exam Score %: ");
        int examScore = Convert.ToInt32(Console.ReadLine());

        //Determines response based on enter percentage score
        if (examScore <= 100 && examScore >= 90)
        {
            Console.WriteLine("You Got an A! Keep Up the Great Work");
        }
        else if (examScore <= 89 && examScore >= 80)
        {
            Console.WriteLine("You Got a B! Good Job, Just Need a Little More Practice");
        }
        else if (examScore <= 79 && examScore >= 70)
        {
            Console.WriteLine("You Got a C! Not Bad, Some More Studying Would Help");
        }
        else if (examScore <= 69 && examScore >= 60)
        {
            Console.WriteLine("You Got a D! It seems you didn't have a complete understanding of the material. Perhaps a tutor would help.");
        }
        else
        {
            Console.WriteLine("You Got an F, you should ask for some help");
        }

        Console.WriteLine("What is your favorite subject: ");
        string favSubject = Console.ReadLine();
        switch(favSubject)
        {
            case "Math" or "math":
            Console.WriteLine("You should keep practicing and exploring new mathematical concepts");
            break;
            case "Science":
            Console.WriteLine("Keep exploring the whys and hows of the world, and keep experimenting");
            break;
            case "English":
            Console.WriteLine("Keep expanding your literary skills by reading new books that challenge you");
            break;
            case "History":
            Console.WriteLine("Keep studying the past to make a better future");
            break;
        }

        //:D(Happy)
    }
}
