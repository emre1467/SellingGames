using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
    class SalesManager : ISalesServices
    {
        public void Sale(User user, Game game)
        {
            Console.WriteLine("{0} adlı kullanıcı {1} isimli oyunu {2} tl ye satın aldı",user.FirstName,game.Name,game.Price);
        }
    }
}
