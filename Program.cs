// Tim Lappalainen NET2024

using System.Linq.Expressions;

bool playing = true;
Random random = new Random();
int lives;
Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
while (playing) //main game loop
{
    MainGame();
}

void MainGame()
{
    const int easyMin = 1;
    const int easyMax = 20;
    const int mediumMin = 1;
    const int mediumMax = 30;
    const int hardMin = 1;
    const int hardMax = 40;
    const int veryHardMin = 1;
    const int veryHardMax = 50;
    const int extremeMin = 1;
    const int extremeMax = 60;
    int minValue;
    int maxValue;



    lives = 5;
    
    Console.WriteLine("Vilken svårighetsgrad skulle du vilja köra på? 1-5 (1 är lättast, 5 svårast)"); //letting the user choose difficulty
    int difficulty = GetValidIntInput("Skriv ett tal mellan 1-5 för svårighetsgrad:");

    switch (difficulty) //checking which difficulty the player chose.
    {
        case 1:
            minValue = easyMin;
            maxValue = easyMax;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 2:
            minValue = mediumMin;
            maxValue = mediumMax;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 3:
            minValue = hardMin;
            maxValue = hardMax;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 4:
            minValue = veryHardMin;
            maxValue = veryHardMax;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        case 5:
            minValue = extremeMin;
            maxValue = extremeMax;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
        default:
            minValue = easyMin;
            maxValue = easyMax;
            Console.WriteLine($"Du får gissa på ett tal mellan {minValue} och {maxValue}");
            break;
    }

    int randomNumber = random.Next(minValue, maxValue + 1);

    for (int attempts = 1; attempts <= 5; attempts++) //main game loop, checking if the users input is correct or not
    {
        int guessedNumber = GetValidIntInput("Gissa ett tal:");
        if (CheckGuess(guessedNumber, randomNumber))
        {
            return;
        }
    }
    Console.WriteLine($"Tyvärr, du lyckades inte gissa talet på fem försök! Talet var {randomNumber}");
    PlayAgain();

}
bool CheckGuess(int guessedNumber, int randomNumber) //Check guessed number against randomed number to see if the user has guessed correctly
{
    if (guessedNumber == randomNumber)
    {
        Console.WriteLine("Grattis, du gissade rätt!");
        PlayAgain();
        return true;
    } //Player guessed correctly
    else if (guessedNumber < randomNumber)
    {
        lives--;
        Console.WriteLine($"Tyvärr, du gissade för lågt. Du har {lives} liv kvar.");

        return false;
    } //Player guessed too low)
    else if (guessedNumber > randomNumber)
    {
        lives--;
        Console.WriteLine($"Tyvärr, du gissade för högt. Du har {lives} liv kvar.");

        return false;
    } //Player guessed too high)
    else
    {
        playing = false;
        return false;
    }

}
void PlayAgain() //method to let the user play another round.
{
    Console.WriteLine("Skulle du vilja testa igen? ja eller nej?");
    var rematch = Console.ReadLine();
    if (rematch?.ToLower() == "ja")
    {
        Console.WriteLine("Då kör vi igen!");
        playing = true; // Set playing to true to continue the main game loop
    }
    else
    {
        Console.WriteLine("Jahapp, det var ju tråkigt för dig");
        playing = false;  // Set playing to false to exit the main game loop
    }
}
int GetValidIntInput(string prompt) //Method to check if the player input is a valid int
{
    int result;
    do
    {
        Console.WriteLine(prompt);
    } while (!int.TryParse(Console.ReadLine(), out result));
    return result;
}


Console.ReadLine();
