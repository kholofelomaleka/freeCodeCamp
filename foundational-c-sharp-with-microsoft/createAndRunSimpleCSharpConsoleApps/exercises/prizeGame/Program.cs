/*
Builds on to the dice game... change the game from "win-or-lose" to awarding fictitious 
prizes for each score. Offer four prizes. However, the player should win only one prize:
    - If the player scores greater or equal to 16, they'll win a new car.
    - If the player scores greater or equal to 10, they'll win a new laptop.
    - If the player scores exactly 7, they'll win a trip.
    - Otherwise, the player wins a kitten.
*/

Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"You rolled {roll1}, {roll2}, and {roll3} for a total of {total}.");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your new total is {total}.");
}

if (total >= 16)
{
    Console.WriteLine("Congratulations! You've won a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("Congratulations! You've won a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("Congratulations! You've won a trip!");
}
else
{
    Console.WriteLine("Congratulations! You've won a kitten!");
}

Console.WriteLine("Thanks for playing! Press any key to exit.");
Console.ReadKey();
Environment.Exit(0);
// End of Program.cs

