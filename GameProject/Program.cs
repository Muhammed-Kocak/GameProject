using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Customer And Customer Manager Instance,Method Calling
            Customer.Customer customer = new Customer.Customer()
            {
                Id = 1,
                Name = "Muhammed",
                SurName = "Koçak",
                BirtYear = 1997,
                IdentificationNumber = "32141355132"
            };

            Customer.CustomerManager customerManager = new Customer.CustomerManager(new Customer.CustomerVerificationManager());
            customerManager.Add(customer);
            #endregion
            #region Campaign And Campaign Manager Instance,Method Calling
            Campaign.Campaigns campaigns = new Campaign.Campaigns()
            {
                Id = 1,
                CampaignId = 1,
                CampaignName = "Nitelikli Yazılımcı Geliştirme Kampı İndirimi",
                DiscountRate = 50,
            };


            Campaign.CampaignManager campaignManager = new Campaign.CampaignManager();
            campaignManager.Add(campaigns);
            #endregion 
            #region Games, Game Manager And GameSales Instance,Method Calling
            GameSales.Games games = new GameSales.Games()
            {
                Id = 1,
                GameId = 1,
                GameName = "Prince Of Persia",
                GamePrice = 1420,
                GameType = "Action",
                UnitStock = 50
            };

            GameSales.Games games2 = new GameSales.Games()
            {
                Id = 1,
                GameId = 1,
                GameName = "Prince Of Persia",
                GamePrice = 1900,
                GameType = "Action",
                UnitStock = 20
            };

            GameSales.GameManager gameManager = new GameSales.GameManager();
            gameManager.Add(games);
            gameManager.Update(games);
            gameManager.Delete(games);

            GameSales.GameSalesManager gameSalesManager = new GameSales.GameSalesManager(campaigns, games2);
            gameSalesManager.GameSale(games2, customer, campaigns);
            #endregion
        }
    }
}
