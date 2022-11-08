using RoshamboLab;
using System;
using System.Reflection.Metadata.Ecma335;


bool playAgain = true;
bool isOpponentValid = false;
string oppName = "";
string oppRoshambo = "";
string playerRoshambo = "";
string playerRoshamboInput = "";
int playerWins = 0;
int playerLoses = 0;

Console.Write("Please enter your name: ");
Player player = new HumanPlayer(Console.ReadLine());
Game game = new Game();

while (!isOpponentValid)
{
    Console.Write($"{player.playerName}, would you like to play against RockPlayer (1) or RandomPlayer (2)? ");
    string opponentInput = Console.ReadLine().ToLower();

    switch (opponentInput)
    {
        case "1":
            RockPlayer rockPlayer = new RockPlayer();
            oppName = rockPlayer.Name;
            oppRoshambo = rockPlayer.GenerateRoshambo().ToString();
            isOpponentValid = true;
            break;
        case "2":
            RandomPlayer randomPlayer = new RandomPlayer();
            oppName = randomPlayer.Name;
            oppRoshambo = randomPlayer.GenerateRoshambo().ToString();
            isOpponentValid = true;
            break;
        default:
            Console.WriteLine("That is not a valid selection");
            isOpponentValid = false;
            break;
    }
    continue;
}

while (playAgain)
{
    bool isRoshamboValid = false;

    while (!isRoshamboValid)
    {
        Console.Write("Rock, Paper or Scissors? (R/P/S)");
        playerRoshamboInput = Console.ReadLine().ToLower();
        isRoshamboValid = Validator.ValidRoshambo(playerRoshamboInput);
        if (!isRoshamboValid)
        {
            Console.WriteLine("That is not a valid selection, try again.");
        }
        continue;
    }
    playerRoshambo = player.GenerateRoshambo(playerRoshamboInput).ToString();

    Console.WriteLine($"{player.playerName} : {playerRoshambo}");
    Console.WriteLine($"{oppName} : {oppRoshambo}");


    Console.WriteLine(game.DetermineWinner(playerRoshambo, oppRoshambo, player.playerName, oppName, playerWins, playerLoses));

    Console.WriteLine("Would you like to play again? ('y' to continue, any other key to quit)");
    string playAgainInput = Console.ReadLine().ToLower();
    playAgain = playAgainInput == "y";
}
Console.WriteLine($"Thank you for playing. Session results - Games won: {game.PlayerWins}. Games lost: {game.PlayerLoses}.");
Environment.Exit(0);