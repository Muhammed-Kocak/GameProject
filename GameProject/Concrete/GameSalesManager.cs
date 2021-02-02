using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.GameSales
{
    class GameSalesManager : IGameSalesService
    {
        private readonly double _indirimFiyati;
        public GameSalesManager(Campaign.Campaigns campaign, Games game)
        {
            _indirimFiyati = game.GamePrice * campaign.DiscountRate / 100;
        }
        public void GameSale(Games game, Customer.Customer customer, Campaign.Campaigns campaigns)
        {
            Console.WriteLine($"{game.GameName} İsimli oyunu {customer.Name}' {campaigns.CampaignName} Adlı Kampanyayı Kullanarak {_indirimFiyati} İndirim İle Satın Aldı! (İndirimsiz Hali:{game.GamePrice})  Haydi Hemen Oynamaya Başla!");
        }
    }
}
