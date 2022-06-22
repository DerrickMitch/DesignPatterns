using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Concrete Order
    internal class SellStockOrder : IOrderCommand
    {
        private StockTrader _trader;

        public SellStockOrder(StockTrader trader)
        {
            _trader = trader;
        }

        public void Execute()
        {
            _trader.Sell();
        }
    }
}
