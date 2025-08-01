/*
This code uses the Random.Next() method to simulate rolling three six-sided dice. 
It evaluates the rolled values to calculate the score. If the score is greater than an 
arbitrary total, display a winning message to the user. If the score is below the cutoff, 
display a losing message to the user.

If any two dice you roll result in the same value, get two bonus points for rolling doubles.
If all three dice you roll result in the same value, get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, win the game. 
Otherwise, lose.
*/

using System.Formats.Asn1;

Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int score = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {score}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        score += 6; // Additional bonus for rolling triples
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        score += 2; // Additional bonus for rolling doubles
    }

}

if (score >= 15)
{
    Console.WriteLine("You win with a score of " + score + "!");
}
else
{
    Console.WriteLine("You lose with a score of " + score + ".");
}