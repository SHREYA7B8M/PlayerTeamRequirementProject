using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Team_Requirement_Project
{
    public class OneDayTeam
    {
        public static List<Player> t20 = new List<Player>();

        public OneDayTeam()
        {
            oneDay.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDay.Count >= 11)
            {
                Console.WriteLine("Team is already full. Can't add more players.");
                return;
            }

            oneDay.Add(player);
            Console.WriteLine("Player added successfully.");
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = oneDay.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDay.Remove(playerToRemove);
                Console.WriteLine("Player removed successfully.");
            }
            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDay.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDay.Find(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDay;
        }
    }
}
