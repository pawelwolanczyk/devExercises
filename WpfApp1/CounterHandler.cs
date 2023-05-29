using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CounterHandler
    {
        private static CounterHandler _instance;
        private int _counter = 0;
        object _lock = new object();

        private CounterHandler()
        {

        }

        public static CounterHandler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CounterHandler();
            }
            return _instance;
        }

        public int Counter
        {
            get
            {
                return _counter;
            }
            private set
            {
                _counter = value;
            }
        }

        public void IncrementCounter()
        {
            lock (_lock)
            {
                ++_counter;
                for (int i = 0; i < 1000000; i++)
                {
                    int j = i * i;
                }
            }
        }
    }
}
