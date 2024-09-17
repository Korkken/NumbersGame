// See https://aka.ms/new-console-template for more information

bool playing = true;
Random random = new Random();
int lives;

while (playing)
{
    MainGame();
}

void MainGame()
{
    int randomNumber = random.Next(1, 21);
    int guessedNumber;
    lives = 5;
    Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

    while (lives != 0) //Continue the game until the person runs out of guesses/lives
    {

        while (!int.TryParse(Console.ReadLine(), out guessedNumber))
        {
            Console.WriteLine("Skriv in en siffra eller ett tal tack");
        }

        CheckGuess(guessedNumber, randomNumber);

    }


    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
    PlayAgain();


}
void CheckGuess(int guessedNumber, int randomNumber) //Check guessed number against randomed number to see if the player has guessed correctly
{
    if (guessedNumber == randomNumber) //Player guessed correctly
    {
        Console.WriteLine("Wohoo! Du klarade det!");
        PlayAgain();

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
void PlayAgain()  //Enables player to play another round after win or loss
{
    Console.WriteLine("Skulle du vilja testa igen? ja eller nej?");
    string rematch = Console.ReadLine();
    if (rematch.ToLower() == "ja")
    {
        playing = true;
    }
    else
    {
        Console.WriteLine("Jahapp, det var ju tråkigt för dig");
        playing = false;
    }

}



Console.ReadLine();
