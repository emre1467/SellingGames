using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
    class CampaignManager : ICampaignServices
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
