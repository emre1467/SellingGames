using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { FirstName = "Emre", LastName = "Yiğit", Tc = "345234", };
            Game gta = new Game {Name="gta",Price=150,CikisTarihi="2013", };
            UserManager userManager = new UserManager();
            userManager.Add(user1);
            SalesManager salesManager = new SalesManager();
            salesManager.Sale(user1, gta);

            Campaign campaign1 = new Campaign {Discount=25,Duration=7,Id=1,Name="Bahar Kampanyası", };
            ICampaignServices campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);
            campaignManager.DeleteCampaign(campaign1);
            
        }
    }
}
