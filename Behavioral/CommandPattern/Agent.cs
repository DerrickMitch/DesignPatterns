using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Invoker
    public class Agent
    {
        private Queue<IOrderCommand> _orderQueue;

        public Agent()
        {
            _orderQueue = new Queue<IOrderCommand>();
        }

        public void PlaceOrder(IOrderCommand order)
        {
            _orderQueue.Enqueue(order);
            _orderQueue.Dequeue().Execute(); // executes oldest order in queue
        }
    }
}
