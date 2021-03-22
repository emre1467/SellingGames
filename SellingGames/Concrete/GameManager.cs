using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
     class GameManager : IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} eklendi",game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} silindi", game.Name);
        }
    }
}
