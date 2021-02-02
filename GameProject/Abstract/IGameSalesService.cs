using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.GameSales
{
    interface IGameSalesService
    {
        void GameSale(Games game, Customer.Customer customer,Campaign.Campaigns campaigns);
    }
}
