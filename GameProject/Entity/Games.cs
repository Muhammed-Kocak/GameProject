using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.GameSales
{
    public class Games
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public double GamePrice { get; set; }
        public int UnitStock { get; set; }
    }
}
