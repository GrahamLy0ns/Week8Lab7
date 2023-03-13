using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Week8Lab7;
using static System.Console;

namespace DataManagement // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Creating db objects");
            using (TeamData db = new TeamData())
            {
                Team t1 = new Team() { TeamID = 1, Name = "Sligo rovers" };
                Player p1 = new Player() { PlayerID = 1, Name = "Pat", Position = "Goalkeeper", TeamID = 1, Team = t1 };
                Player p2 = new Player() { PlayerID = 2, Name = "Joe", Position = "Forward", TeamID = 1, Team = t1 };

                Team t2 = new Team() { TeamID = 1, Name = "Sligo rovers" };
                Player p3 = new Player() { PlayerID = 3, Name = "Mike", Position = "Goalkeeper", TeamID = 2, Team = t2 };
                Player p4 = new Player() { PlayerID = 4, Name = "John", Position = "Forward", TeamID = 2, Team = t2 };


                WriteLine("Created objects");
                //add to db
                db.Teams.Add(t1);
                db.Teams.Add(t2);
                WriteLine("Added teams to db");

                //adding players
                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);

                WriteLine("Added players");

                db.SaveChanges();

                WriteLine("Saved changes to db");
            }
                

            


        }
    }
}
