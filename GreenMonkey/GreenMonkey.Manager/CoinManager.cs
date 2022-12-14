using GreenMonkey.DataAccess.Crud;
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
        public SuscriptorCrudFactory SuscriptorFactory { get; private set; }
        public CoinManager()
        {
            CoinFactory = new CoinCrudFactory();
            SuscriptorFactory = new SuscriptorCrudFactory();
        }

        public void CreateCoin(Coin coin)
        {
            CoinFactory.Create(coin);
        }

        public List<Coin> RetrieveAllCoin()
        {
            return CoinFactory.RetrieveAll<Coin>();
        }

        public List<Coin> RetrieveAllCoinWithFintech()
        {
            var coins = CoinFactory.RetrieveAll<Coin>();

            foreach(var coin in coins)
            {
                coin.Fintech = SuscriptorFactory.Retrieve<Suscriptor>(new Suscriptor() { Code = coin.FintechCode });
            }

            return coins;
        }

        public Coin RetrieveCoin(Coin coin)
        {
            return CoinFactory.Retrieve<Coin>(coin);
        }

        public Coin RetrieveCoinByFintech(Coin coin)
        {
            return CoinFactory.RetrieveByFintech<Coin>(coin);
        }
    }
}
