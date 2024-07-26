Random rnd = new Random();
int score = 0;

Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine(name + ", would you like to do the Coin Flip Challenge?");
string answer = Console.ReadLine();
if (answer == "Yes")
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Heads or Tails?");
        answer = Console.ReadLine();
        if (rnd.Next(0,2) == 0)
        {
            if (answer == "Heads")
            {
                Console.WriteLine("Correct!");
                score++;
            }else
            {
                Console.WriteLine("Wrong!");
            }
        }else
        {
            if (answer == "Tails")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
    }

    Console.WriteLine("Thank you, " + name + ". You got a score of " + score + ".");
}
else
{
    Console.WriteLine("You're a coward, " + name + ".");
}