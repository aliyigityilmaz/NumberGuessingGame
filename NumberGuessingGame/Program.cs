bool isCorrectGuess = false;
Random random = new Random();

int randomNum = random.Next(1, 101);

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("Try to guess it in 10 attempts.");
Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"You have {10 - i} attempts left.");
    Console.Write("Enter your guess: ");
    int playerGuess = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (playerGuess > randomNum)
    {
        Console.WriteLine("Your guess is higher than the number");
        Console.WriteLine();
    }
    else if (playerGuess < randomNum)
    {
        Console.WriteLine("Your guess is lower than the number");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("You guessed the number!");
        Console.WriteLine();
        isCorrectGuess = true;
        break;
    }
}
if (isCorrectGuess == false)
{
    Console.WriteLine("You lose!");
    Console.WriteLine($"The number was {randomNum}");    
}