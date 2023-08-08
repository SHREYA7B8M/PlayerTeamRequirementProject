using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Team_Requirement_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            T20Team t20Team = new T20Team();

            while (true)
            {
                Console.WriteLine("\nWelcome to Cricket T20 Management System");
                Console.WriteLine("Enter your choice: \n1: To Add Player \n2: To Remove Player by Id \n3: Get Player By Id \n4: Get Player by Name \n5: Get All Players \n6: Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input Player Id:");
                        int playerId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Input Player Name:");
                        string playerName = Console.ReadLine();

                        Console.WriteLine("Input Player Age:");
                        int playerAge = int.Parse(Console.ReadLine());

                        Player newPlayer = new Player
                        {
                            PlayerId = playerId,
                            PlayerName = playerName,
                            PlayerAge = playerAge
                        };
                        t20Team.Add(newPlayer);
                        break;

                    case 2:
                        Console.WriteLine("Enter Player Id to remove:");
                        int playerIdToRemove = int.Parse(Console.ReadLine());
                        t20Team.Remove(playerIdToRemove);
                        break;

                    case 3:
                        Console.WriteLine("Enter Player Id to retrieve:");
                        int playerIdToRetrieve = int.Parse(Console.ReadLine());
                        Player retrievedPlayerById = t20Team.GetPlayerById(playerIdToRetrieve);
                        if (retrievedPlayerById != null)
                            Console.WriteLine($"Player found: Id={retrievedPlayerById.PlayerId}, Name={retrievedPlayerById.PlayerName}, Age={retrievedPlayerById.PlayerAge}");
                        else
                            Console.WriteLine("Player not found.");
                        break;

                    case 4:
                        Console.WriteLine("Enter Player Name to retrieve:");
                        string playerNameToRetrieve = Console.ReadLine();
                        Player retrievedPlayerByName = t20Team.GetPlayerByName(playerNameToRetrieve);
                        if (retrievedPlayerByName != null)
                            Console.WriteLine($"Player found: Id={retrievedPlayerByName.PlayerId}, Name={retrievedPlayerByName.PlayerName}, Age={retrievedPlayerByName.PlayerAge}");
                        else
                            Console.WriteLine("Player not found.");
                        break;

                    case 5:
                        var allPlayers = t20Team.GetAllPlayers();
                        Console.WriteLine("All Players:");
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Id={player.PlayerId}, Name={player.PlayerName}, Age={player.PlayerAge}");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                     break;
                }
            }
        }
    }
}
