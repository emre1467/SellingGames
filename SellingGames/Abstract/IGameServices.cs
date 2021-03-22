using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
     interface IGameServices
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
