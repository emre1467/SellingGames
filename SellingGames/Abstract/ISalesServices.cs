using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
    interface ISalesServices
    {
        void Sale(User user, Game game);
    }
}
