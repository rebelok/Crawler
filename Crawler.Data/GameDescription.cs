using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Data
{
    public enum GameType
    {
        Action,
        Arcade,
        RPG,
        Strategy,
        Racing,
        Logic,
        Table,
        Sport,
        Study,
        Education,
        Other

    }
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OS { get; set; }
        public string MarketUrl { get; set; }
        public string CoverlUrl { get; set; }

        public GameType Type { get; set; }
        
    }
}
