using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Lab7
{
    public class ComputerGame
    {
        [Key]
        public int GameID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public virtual List<Character> Characters { get; set; }


    }
    public class Character
    {
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string CharacterBackground { get; set; }
        public string CharacterType { get; set; }
        

        public int GameID { get; set; }
        public virtual ComputerGame ComputerGame { get; set; }
    }
    public class ComputerGameData : DbContext
    {
        public ComputerGameData() : base("MyComputerGameData") { }
        public DbSet<ComputerGame> ComputerGames { get; set; }
        public DbSet<Character> Characters { get; set; }

    }
}
