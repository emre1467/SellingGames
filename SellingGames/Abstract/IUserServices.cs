﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingGames
{
     interface IUserServices
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
    }
}
