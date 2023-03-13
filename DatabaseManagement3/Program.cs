using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Week8Lab7;
using static System.Console;

namespace DatabaseManagement3
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Creating db objects");
            ComputerGameData db = new ComputerGameData();
            using (db)
            {
                ComputerGame hogwartsLegacy = new ComputerGame() { Name = "Hogwarts Legacy", Price = 60, Description = "Become a wizard and go on quests", GameID = 1};
                ComputerGame terraria = new ComputerGame() { Name = "Terraria", Price = 15, Description = "Dig, Fight, Explore!", GameID = 2 };
                ComputerGame assettoCorsa = new ComputerGame() { Name = "Assetto Corsa", Price = 20, Description = "Driving simulation", GameID = 3 };

                Character char1 = new Character() { Name = "Harry Potter", CharacterBackground = "Orphan", CharacterType = "Wizard", Level = 27, CharacterID = 1, GameID=1};
                Character char2 = new Character() { Name = "Gilbert", Level = 12, CharacterType = "Rouge", CharacterBackground = "Pixel", CharacterID = 1, GameID=2};
                Character char3 = new Character() { Name = "Stingray", Level = 1, CharacterType = "Car", CharacterBackground = "Car History", CharacterID = 1, GameID=3};

                WriteLine("Created objects");
                db.ComputerGames.Add(hogwartsLegacy);
                db.ComputerGames.Add(terraria);
                db.ComputerGames.Add(assettoCorsa);
                WriteLine("Added games to db");

                db.Characters.Add(char1);
                db.Characters.Add(char2);
                db.Characters.Add(char3);
                WriteLine("Added characters to db");

                db.SaveChanges();
                WriteLine("saved changes");
            }
        }
    }
}
