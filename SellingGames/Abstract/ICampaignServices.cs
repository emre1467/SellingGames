using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
    interface ICampaignServices
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}
