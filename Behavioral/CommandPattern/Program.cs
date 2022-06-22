using CommandPattern;

// Command pattern allows us to seperate concerns of operations into their own objects. This is especially helpful with Unit testing, as we can run a test to see if a
// command executes the way we would expect, without having the run the entire application.

// Client

StockTrader Trader = new StockTrader();

// Create our commands, and pass in our reciever as a service to operate on
BuyStockOrder buy = new BuyStockOrder(Trader);
SellStockOrder sell = new SellStockOrder(Trader);

// Create our invoker. This handles queueing and executing our commands
Agent agent = new Agent();

agent.PlaceOrder(buy);
agent.PlaceOrder(sell);