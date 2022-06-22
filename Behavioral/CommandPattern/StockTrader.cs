using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Receiver 
    // Represents our service, performing actions
    public class StockTrader
    {
        public void Buy()
        {
            Console.WriteLine("Buying stocks...");
        }

        public void Sell()
        {
            Console.WriteLine("Selling stocks...");
        }
    }
}
