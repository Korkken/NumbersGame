// See https://aka.ms/new-console-template for more information


Random random = new Random();
int lives = 5;
int randomNumber = random.Next(1, 21);
Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
while (lives > 0)
{
    
    int.TryParse(Console.ReadLine(), out int guessedNumber);
    if (guessedNumber == randomNumber)
    {
        Console.WriteLine("Wohoo! Du klarade det!");
        
    }
    else if (guessedNumber < randomNumber && lives > 0)
    {
        Console.WriteLine("Tyvärr, du gissade för lågt!");
        lives--;
        
    }
    else if (guessedNumber > randomNumber && lives > 0)
    {
        Console.WriteLine("Tyvärr, du gissade för högt!");
        lives--;
        
    }

}
if ( lives== 0) { Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!"); }

Console.ReadLine();