using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Concrete Order
    public class BuyStockOrder : IOrderCommand
    {
        private StockTrader _trader;

        public BuyStockOrder(StockTrader trader)
        {
            _trader = trader;
        }

        public void Execute()
        {
            _trader.Buy();
        }
    }
}
