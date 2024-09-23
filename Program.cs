// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

bool playing = true;
Random random = new Random();
int lives;

while (playing)
{
    MainGame();
}

void MainGame()
{
    int minValue;
    int maxValue;

    int guessedNumber;
    int difficulty;
    lives = 5;
    Console.WriteLine("Vilken svårighetsgrad skulle du vilja köra på? 1-5 (1 är lättast, 5 svårast)");
    int.TryParse(Console.ReadLine(), out difficulty);
    switch (difficulty)
    {
        case 1:
            minValue = 1;
            maxValue = 21;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 2:
            minValue = 1;
            maxValue = 31;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 3:
            minValue = 1;
            maxValue = 41;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 4:
            minValue = 1;
            maxValue = 51;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 5:
            minValue = 1;
            maxValue = 61;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        default:
            minValue = 1;
            maxValue = 21;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
    }
    int randomNumber = random.Next(minValue, maxValue);
    Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

    while (lives != 0) //Continue the game until the person runs out of guesses/lives
    {

        while (!int.TryParse(Console.ReadLine(), out guessedNumber))
        {
            Console.WriteLine("Skriv in en siffra eller ett tal tack");
        }

        CheckGuess(guessedNumber, randomNumber);
    }





}
void CheckGuess(int guessedNumber, int randomNumber) //Check guessed number against randomed number to see if the player has guessed correctly
{
    if (guessedNumber == randomNumber) //Player guessed correctly
    {
        Console.WriteLine("Wohoo! Du klarade det!");
        PlayAgain();
        lives = 0;
    }
    else if (guessedNumber < randomNumber) //Player guessed a number that was lower than the randomed number
    {
        Console.WriteLine("Tyvärr, du gissade för lågt!");
        lives--;
        if (lives == 0)
        {
            Console.WriteLine($"Tyvärr, du lyckades inte gissa talet på fem försök! Talet var {randomNumber}");
            PlayAgain();
        }
    }
    else if (guessedNumber > randomNumber) //Player guessed a number that was higher than the randomed number
    {
        Console.WriteLine("Tyvärr, du gissade för högt!");
        lives--;
        if (lives == 0)
        {
            Console.WriteLine($"Tyvärr, du lyckades inte gissa talet på fem försök! Talet var {randomNumber}");
            PlayAgain();
        }

    }

}
void PlayAgain()  //asks if player wants to play another round.
{
    Console.WriteLine("Skulle du vilja testa igen? ja eller nej?");
    string rematch = Console.ReadLine();
    if (rematch.ToLower() == "ja")
    {

        Console.WriteLine("Då kör vi igen!");
    }
    else
    {
        Console.WriteLine("Jahapp, det var ju tråkigt för dig");
        playing = false;
    }

}



Console.ReadLine();
