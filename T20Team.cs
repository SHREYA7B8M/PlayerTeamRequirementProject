using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Team_Requirement_Project
{
    public class T20Team
    {
        public static List<Player> T20team = new List<Player>();

        public T20Team()
        {
            T20team.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (T20team.Count >= 11)
            {
                Console.WriteLine("Team is already full. Can't add more players.");
                return;
            }

            T20team.Add(player);
            Console.WriteLine("Player added successfully.");
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = T20team.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                T20team.Remove(playerToRemove);
                Console.WriteLine("Player removed successfully.");
            }
            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return T20team.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return T20team.Find(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return T20team;
        }
    }
}
