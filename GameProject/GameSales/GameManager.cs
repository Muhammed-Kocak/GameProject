using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.GameSales
{
    class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine($"{game.GameName} Adlı Oyun Eklendi! ");
        }

        public void Delete(Games game)
        {
            Console.WriteLine($"{game.GameName} Adlı Oyun Silindi! ");
        }

        public void Update(Games game)
        {
            Console.WriteLine($"{game.GameName} Adlı Oyun Güncellendi! ");
        }
    }
}
