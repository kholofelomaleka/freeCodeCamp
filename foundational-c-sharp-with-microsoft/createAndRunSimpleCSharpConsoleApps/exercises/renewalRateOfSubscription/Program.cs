/*
Display a renewal message when a user logs into the software system and is notified 
their subscription will soon end. 
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration < 2)
{
    Console.WriteLine($"Your subscription expires within {daysUntilExpiration} day.");
    discountPercentage = 20;
}
else if (daysUntilExpiration < 6)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration < 11)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine("Your subscription is active.");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}