namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            //Shouldn't this be 1001 to include 1000 because upper bound is exclusive in this case? Changed upper bound to 1001
            var favNumber = r.Next(1, 1001);
            Console.WriteLine("Let's play a number guessing game, guess an integer from 1-1000");

            //Initiates a while loop to allow the user to guess the number until they get it right
            while (true)
            {
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine("You got it!");

                    //Exits the loop once the number has been guessed
                    break;                   
                }
            }
        }
    }
}
