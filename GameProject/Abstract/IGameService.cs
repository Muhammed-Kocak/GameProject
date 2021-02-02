using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.GameSales
{
    interface IGameService
    {
        void Add(Games game);
        void Update(Games game);
        void Delete(Games game);
    }
}
