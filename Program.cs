// See https://aka.ms/new-console-template for more information


Random random = new Random();
int lives;
int randomNumber = random.Next(1, 21);

MainGame();
void MainGame()
{
    lives = 5;
    Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
    while (lives > 0) //Continue the game until the person runs out of guesses/lives
    {

        int.TryParse(Console.ReadLine(), out int guessedNumber);
        CheckGuess(guessedNumber);

    }
}
void CheckGuess(int guessedNumber) //Check guessed number against randomed number to see if the player has guessed correctly
{
    if (guessedNumber == randomNumber) //Player guessed correctly
    {
        Console.WriteLine("Wohoo! Du klarade det!");  

    }
    else if (guessedNumber < randomNumber && lives > 0) //Player guessed a number that was lower than the randomed number
    {
        Console.WriteLine("Tyvärr, du gissade för lågt!");
        lives--;

    }
    else if (guessedNumber > randomNumber && lives > 0) //Player guessed a number that was higher than the randomed number
    {
        Console.WriteLine("Tyvärr, du gissade för högt!");
        lives--;

    }
}
if (lives == 0) { Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!"); } //Player ran out of lives

Console.WriteLine("Skulle du vilja testa igen? ja eller nej?");
string rematch = Console.ReadLine();
if (rematch.ToLower() == "ja")
{
    MainGame();
}
else { Console.WriteLine("Jahapp, det var ju tråkigt för dig"); }

