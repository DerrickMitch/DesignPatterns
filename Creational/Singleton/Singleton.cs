using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton? _instance;

        private Singleton()
        {
            // private contructor
        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }
}
