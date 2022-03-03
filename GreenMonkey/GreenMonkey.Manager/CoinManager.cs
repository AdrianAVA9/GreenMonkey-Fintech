﻿using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Manager
{
    public class CoinManager
    {
        public CoinCrudFactory CoinFactory { get; private set; }
        public CoinManager()
        {
            CoinFactory = new CoinCrudFactory();
        }

        public void CreateCoin(Coin coin)
        {
            CoinFactory.Create(coin);
        }
    }
}
