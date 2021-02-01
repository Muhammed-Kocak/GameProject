using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Campaign
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} Adlı Kampanya Eklendi!");
        }

        public void Deleted(Campaigns campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} Adlı Kampanya Silindi!");
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} Adlı Kampanya Düzenlendi!");
        }
    }
}
