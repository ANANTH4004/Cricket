using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(1, "Anand", 21);
            Player p2 = new Player(2, "Hirthikk", 22);
            Player p3 = new Player(3, "Veeman", 22);
            Player p4 = new Player(4, "Keerthi", 30);
            Player p5 = new Player(5, "Thanga", 30);
            Player p6 = new Player(6, "Mukil", 30);
            Player p7 = new Player(7, "Ragul", 30);
            Player p11 = new Player(8, "Saran", 30);
            Player p8 = new Player(9, "Sivaram", 30);
            Player p9 = new Player(10, "Saravanan", 30);
            Player p10 = new Player(11, "Balaji", 30);
            Player p12 = new Player(12, "Adityen", 30);
            OneDayTeam Team1 = new OneDayTeam();
            Team1.Add(p1);
            Team1.Add(p2);
            Team1.Add(p3);
            Team1.Add(p4);
            Team1.Add(p5);
            Team1.Add(p6);
            Team1.Add(p7);
            bool con = false;
            do
            {
                Console.WriteLine("Enter 1.Add Player 2.Remove Player by Id 3.Get Player by Id 4.Get Player by Name 5.Get All Players");
                int Choice = Int32.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Team1.Add();
                        break;
                    case 2:
                        Console.WriteLine("Enter Player Id");
                        int id = Int32.Parse(Console.ReadLine());
                        Team1.Remove(id);
                        break;
                    case 3:
                        Console.WriteLine("Enter Id ");
                       
                                Console.WriteLine("Enter Player Id");
                                int id1 = Int32.Parse(Console.ReadLine());
                                Player p = new Player();
                                p =Team1.GetPlayerById(id1);
                                Console.WriteLine($"Player ID : {p.PlayerId} Player Name {p.PlayerName} Player Age : {p.PlayerAge}");
                        break;
                    case 4:
                        Player pp = new Player();
                        Console.WriteLine("Enter Player Name");
                        string name = Console.ReadLine();
                        pp = Team1.GetPlayerByName(name);
                        Console.WriteLine($"Player ID : {pp.PlayerId} Player Name {pp.PlayerName} Player Age : {pp.PlayerAge}");

                        break;
                    case 5:
                        Team1.GetAllPlayer();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue (yes/no) ? : ");
                string ans = Console.ReadLine();
                if (ans == "yes" || ans == "Yes")
                {
                    con = true;
                }
                else { con = false; }
            } while (con);
        }
    }
}
