using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
     class UserManager : IUserServices
    {
        public void Add(User user)
        {
            Console.WriteLine("{0} {1} eklendi",user.FirstName,user.LastName);
        }

        public void Delete(User user)
        {
            Console.WriteLine("{0} {1} Silindi", user.FirstName, user.LastName);
        }

        public void Update(User user)
        {
            Console.WriteLine("{0} {1} güncellendi", user.FirstName, user.LastName);
        }
    }
}
