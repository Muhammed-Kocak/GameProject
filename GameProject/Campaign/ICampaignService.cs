using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Campaign
{
    interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Deleted(Campaigns campaign);
        void Update(Campaigns campaign);
    }
}
