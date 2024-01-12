using System;
using System.Collections.Generic;

namespace Player_and_Team_Project
{
    class Program
    {
        static void Main()
        {
            OneDayTeam oneDayTeam = new OneDayTeam();

            while (true)
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Player details:");
                        Console.Write("Player Id: ");
                        int playerId = int.Parse(Console.ReadLine());
                        Console.Write("Player Name: ");
                        string playerName = Console.ReadLine();
                        Console.Write("Player Age: ");
                        int playerAge = int.Parse(Console.ReadLine());

                        Player newPlayer = new Player
                        {
                            PlayerId = playerId,
                            PlayerName = playerName,
                            PlayerAge = playerAge
                        };

                        oneDayTeam.Add(newPlayer);
                        break;

                    case 2:
                        Console.Write("Enter Player Id to remove: ");
                        int removePlayerId = int.Parse(Console.ReadLine());
                        oneDayTeam.Remove(removePlayerId);
                        break;

                    case 3:
                        Console.Write("Enter Player Id to get details: ");
                        int getPlayerId = int.Parse(Console.ReadLine());
                        Player getPlayerByIdResult = oneDayTeam.GetPlayerById(getPlayerId);
                        Console.WriteLine(getPlayerByIdResult != null ? $"Player found: {getPlayerByIdResult.PlayerName}" : "Player not found.");
                        break;

                    case 4:
                        Console.Write("Enter Player Name to get details: ");
                        string getPlayerName = Console.ReadLine();
                        Player getPlayerByNameResult = oneDayTeam.GetPlayerByName(getPlayerName);
                        Console.WriteLine(getPlayerByNameResult != null ? $"Player found: {getPlayerByNameResult.PlayerName}" : "Player not found.");
                        break;

                    case 5:
                        List<Player> allPlayers = oneDayTeam.GetAllPlayers();
                        Console.WriteLine("All Players in the team:");
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Player Id: {player.PlayerId}, Player Name: {player.PlayerName}, Player Age: {player.PlayerAge}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Press 'Q' to quit or any other key to continue.");
                if (Console.ReadLine().ToUpper() == "Q")
                {
                    break;
                }
            }
        }
    }
}