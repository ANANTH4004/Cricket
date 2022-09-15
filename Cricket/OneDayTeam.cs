using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cricket
{
    public class OneDayTeam : ITeam
    {
        public int Capacity { get; set; }
        public int count = 0;
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            this.Capacity = 11;
        }
        public void Add(Player player)
        {
            if (count < Capacity)
            {
                oneDayTeam.Add(player);
                count++;
                Console.WriteLine("Player Added Successfully...");
            }
            else
            {
                Console.WriteLine("Team is full...");
            }
        }
        public void Add()
        {
            if (count <Capacity)
            {
                Player p = new Player();
                Console.WriteLine("Enter Player id");
                p.PlayerId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Player Name :");
                p.PlayerName = Console.ReadLine();
                Console.WriteLine("Enter Player Age ");
                int age = Convert.ToInt32(Console.ReadLine());
                p.PlayerAge = age;
                oneDayTeam.Add(p);
                count++;
            }
            else
            {
                Console.WriteLine("Team is Full...");
            }
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
        public void GetAllPlayer()
        {
            foreach (var item in oneDayTeam)
            {
                Console.WriteLine($"Player ID : {item.PlayerId} Player Name: {item.PlayerName}");
            }
            Console.WriteLine("============================");
        }

        public Player GetPlayerById(int playerId)
        {
            var found = oneDayTeam.Find(fo => fo.PlayerId == playerId);
            if (found != null)
            {
                //Console.WriteLine($"Player {playerId} Found");
                //Console.WriteLine($"Player Id : {found.PlayerId} Player Name : {found.PlayerName} Age : {found.PlayerAge}");
                return found;
            }
            else
            {
                Console.WriteLine($"Player {playerId} Not Found!!");
                return null;
            }
        }

        public Player GetPlayerByName(string playerName)
        {
            var found = oneDayTeam.Find(fo => fo.PlayerName == playerName);
            if (found != null)
            {
                //Console.WriteLine($"Player {playerName} Found");
                //Console.WriteLine($"Player Id : {found.PlayerId} Player Name : {found.PlayerName} Age : {found.PlayerAge}");
                return found;
            }
            else
            {
                Console.WriteLine($"Player {playerName} Not Found!!");
                return null;
            }
        }

        public void Remove(int PlayerId)
        {
            var found = oneDayTeam.Single(r => r.PlayerId == PlayerId);
            if (found != null)
            {
                oneDayTeam.Remove(found);
                this.count--;
                Console.WriteLine($"Player {PlayerId} Removed Successfully....");
            }
            else
            {
                Console.WriteLine($"Player {PlayerId} Not Found");
            }
        }
    }
}
